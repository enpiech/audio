using Core.Gameplay.Setting.AtomGenerated.References;
using Enpiech.Audio.Runtime.Data;
using Enpiech.Audio.Runtime.SoundEmitters;
using NaughtyAttributes;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Audio;

namespace Enpiech.Audio.Runtime
{
    public sealed class AudioController : MonoBehaviour
    {
        [Header("SoundEmitters pool")]
        [SerializeField]
        private SoundEmitterPoolSO _pool = default!;

        [SerializeField]
        [MinValue(0)]
        private int _initialSize = 10;

        [Header("Listening to")]
        [Tooltip("The SoundManager listens to this event, fired by objects in any scene, to play SFXs")]
        [SerializeField]
        private AudioCueEventChannelSO _sfxEventChannel = default!;

        [Tooltip("The SoundManager listens to this event, fired by objects in any scene, to play Music")]
        [SerializeField]
        private AudioCueEventChannelSO _musicEventChannel = default!;

        [Tooltip("The SoundManager listens to this event, fired by objects in any scene, to change SFXs volume")]
        [SerializeField]
        private FloatEvent _changeSFXVolumeEventChannel = default!;

        [Tooltip("The SoundManager listens to this event, fired by objects in any scene, to change Music volume")]
        [SerializeField]
        private FloatEvent _changeMusicVolumeEventChannel = default!;

        [Tooltip("The SoundManager listens to this event, fired by objects in any scene, to change Master volume")]
        [SerializeField]
        private FloatEvent _changeMasterVolumeEventChannel = default!;

        [Header("Audio control")]
        [SerializeField]
        private AudioMixer _audioMixer = default!;

        [SerializeField]
        private SettingReference _currentSetting = default!;

        private SoundEmitter? _musicSoundEmitter;

        private SoundEmitterRuntimeSet _soundEmitterRuntimeSet = default!;

        private void Awake()
        {
            _soundEmitterRuntimeSet = ScriptableObject.CreateInstance<SoundEmitterRuntimeSet>();

            _pool.Prewarm(_initialSize);
            _pool.SetParent(transform);
        }

        private void OnEnable()
        {
            _sfxEventChannel.OnAudioCuePlayRequested += PlayAudioCue;
            _sfxEventChannel.OnAudioCueStopRequested += StopAudioCue;
            _sfxEventChannel.OnAudioCueFinishRequested += FinishAudioCue;

            _musicEventChannel.OnAudioCuePlayRequested += PlayMusicTrack;
            _musicEventChannel.OnAudioCueStopRequested += StopMusic;

            _changeMasterVolumeEventChannel.Register(OnChangeMasterVolume);
            _changeMusicVolumeEventChannel.Register(OnChangeMusicVolume);
            _changeSFXVolumeEventChannel.Register(OnChangeSFXVolume);
        }

        private void OnDestroy()
        {
            _sfxEventChannel.OnAudioCuePlayRequested -= PlayAudioCue;
            _sfxEventChannel.OnAudioCueStopRequested -= StopAudioCue;

            _sfxEventChannel.OnAudioCueFinishRequested -= FinishAudioCue;
            _musicEventChannel.OnAudioCuePlayRequested -= PlayMusicTrack;

            _changeMasterVolumeEventChannel.Unregister(OnChangeMasterVolume);
            _changeMusicVolumeEventChannel.Unregister(OnChangeMusicVolume);
            _changeSFXVolumeEventChannel.Unregister(OnChangeSFXVolume);
        }

        /// <summary>
        ///     This is only used in the Editor, to debug volumes.
        ///     It is called when any of the variables is changed, and will directly change the value of the volumes on the
        ///     AudioMixer.
        /// </summary>
#if UNITY_EDITOR
        private void OnValidate()
        {
            if (!Application.isPlaying)
            {
                return;
            }
            OnChangeMasterVolume(_currentSetting.Value.MasterVolume);
            OnChangeMusicVolume(_currentSetting.Value.MusicVolume);
            OnChangeSFXVolume(_currentSetting.Value.SFXVolume);
        }
#endif

        private void OnChangeMasterVolume(float newVolume)
        {
            SetGroupVolume("MasterVolume", newVolume);
        }

        private void OnChangeMusicVolume(float newVolume)
        {
            SetGroupVolume("MusicVolume", newVolume);
        }

        private void OnChangeSFXVolume(float newVolume)
        {
            SetGroupVolume("SFXVolume", newVolume);
        }

        public void SetGroupVolume(string parameterName, float normalizedVolume)
        {
            var volumeSet = _audioMixer.SetFloat(parameterName, NormalizedToMixerValue(normalizedVolume));
            if (!volumeSet)
            {
                Debug.LogError("The AudioMixer parameter was not found");
            }
        }

        public float GetGroupVolume(string parameterName)
        {
            if (_audioMixer.GetFloat(parameterName, out var rawVolume))
            {
                return MixerValueToNormalized(rawVolume);
            }

            Debug.LogError("The AudioMixer parameter was not found");
            return 0f;
        }

        // Both MixerValueNormalized and NormalizedToMixerValue functions are used for easier transformations
        /// when using UI sliders normalized format
        private static float MixerValueToNormalized(float mixerValue)
        {
            // We're assuming the range [-80dB to 0dB] becomes [0 to 1]
            return 1f + mixerValue / 80f;
        }

        private static float NormalizedToMixerValue(float normalizedValue)
        {
            // We're assuming the range [0 to 1] becomes [-80dB to 0dB]
            // This doesn't allow values over 0dB
            return (normalizedValue - 1f) * 80f;
        }

        private AudioCueKey PlayMusicTrack(AudioCueSO audioCue, AudioConfigurationSO audioConfiguration, Vector3 positionInSpace)
        {
            const float fadeDuration = 2f;
            var startTime = 0f;

            if (_musicSoundEmitter != null && _musicSoundEmitter.IsPlaying)
            {
                var songToPlay = audioCue.Clips[0];
                if (_musicSoundEmitter.Clip == songToPlay)
                {
                    return AudioCueKey.Invalid;
                }

                //Music is already playing, need to fade it out
                startTime = _musicSoundEmitter.FadeMusicOut(fadeDuration);
            }

            _musicSoundEmitter = _pool.Request();
            _musicSoundEmitter.FadeMusicIn(audioCue.Clips[0], audioConfiguration, 1f, startTime);
            _musicSoundEmitter.OnSoundFinishedPlaying += StopMusicEmitter;

            return AudioCueKey.Invalid; //No need to return a valid key for music
        }

        private void StopMusicEmitter(SoundEmitter soundEmitter)
        {
            soundEmitter.OnSoundFinishedPlaying -= StopMusicEmitter;
            _pool.Return(soundEmitter);
        }

        private bool StopMusic(AudioCueKey key)
        {
            if (_musicSoundEmitter is not { IsPlaying: true })
            {
                return false;
            }

            _musicSoundEmitter.Stop();
            return true;
        }

        /// <summary>
        ///     Only used by the timeline to stop the gameplay music during cutscenes.
        ///     Called by the SignalReceiver present on this same GameObject.
        /// </summary>
        public void TimelineInterruptsMusic()
        {
            StopMusic(AudioCueKey.Invalid);
        }

        /// <summary>
        ///     Plays an AudioCue by requesting the appropriate number of SoundEmitters from the pool.
        /// </summary>
        public AudioCueKey PlayAudioCue(AudioCueSO audioCue, AudioConfigurationSO settings, Vector3 position = default)
        {
            var clipsToPlay = audioCue.Clips;
            var soundEmitterArray = new SoundEmitter[clipsToPlay.Length];

            var nOfClips = clipsToPlay.Length;
            for (var i = 0; i < nOfClips; i++)
            {
                soundEmitterArray[i] = _pool.Request();
                if (soundEmitterArray[i] == null)
                {
                    continue;
                }

                soundEmitterArray[i].PlayAudioClip(clipsToPlay[i], settings, audioCue.IsLooping, position);
                if (!audioCue.IsLooping)
                {
                    soundEmitterArray[i].OnSoundFinishedPlaying += OnSoundEmitterFinishedPlaying;
                }
            }

            return _soundEmitterRuntimeSet.Add(audioCue, soundEmitterArray);
        }

        public bool FinishAudioCue(AudioCueKey audioCueKey)
        {
            var isFound = _soundEmitterRuntimeSet.Get(audioCueKey, out var soundEmitters);

            if (isFound)
            {
                foreach (var soundEmitter in soundEmitters)
                {
                    soundEmitter.Finish();
                    soundEmitter.OnSoundFinishedPlaying += OnSoundEmitterFinishedPlaying;
                }
            }
            else
            {
                Debug.LogWarning("Finishing an AudioCue was requested, but the AudioCue was not found.");
            }

            return isFound;
        }

        public bool StopAudioCue(AudioCueKey audioCueKey)
        {
            var isFound = _soundEmitterRuntimeSet.Get(audioCueKey, out var soundEmitters);

            if (!isFound)
            {
                return isFound;
            }

            foreach (var soundEmitter in soundEmitters)
            {
                StopAndCleanEmitter(soundEmitter);
            }

            _soundEmitterRuntimeSet.Remove(audioCueKey);
            return isFound;
        }

        private void OnSoundEmitterFinishedPlaying(SoundEmitter soundEmitter)
        {
            StopAndCleanEmitter(soundEmitter);
        }

        private void StopAndCleanEmitter(SoundEmitter soundEmitter)
        {
            if (!soundEmitter.IsLooping)
            {
                soundEmitter.OnSoundFinishedPlaying -= OnSoundEmitterFinishedPlaying;
            }

            soundEmitter.Stop();
            _pool.Return(soundEmitter);

            //TODO: is the above enough?
            //_soundEmitterVault.Remove(audioCueKey); is never called if StopAndClean is called after a Finish event
            //How is the key removed from the vault?
        }
    }
}