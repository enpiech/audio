using Audio.Data;
using Audio.SoundEmitters;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Audio.AtomGenerated.Functions.AudioCueKeyAudioCueRequest
{
    /// <summary>
    ///     Event on which <c>AudioCue</c> components send a message to play SFX and music. <c>AudioManager</c> listens on
    ///     these events, and actually plays the sound.
    /// </summary>
    /// [EditorIcon("atom-icon-sand")]
    [EditorIcon("atom-icon-sand")]
    [CreateAssetMenu(menuName = "Unity Atoms/Functions/Audio/PlayMusic (AudioCueRequest => AudioCueKey)")]
    public abstract class PlayMusic : PlayAudioCue
    {
        [Header("Config")]
        [SerializeField]
        private FloatReference _fadeMusicOutDuration = default!;

        [SerializeField]
        private FloatReference _fadeMusicInDuration = default!;

        [Header("References")]
        [SerializeField]
        private SoundEmitterRuntimeSet _soundEmitterRuntimeSet = default!;

        public override AudioCueKey Call(AudioCueRequest request)
        {
            var startTime = 0f;

            var musicSoundEmitter = _soundEmitterRuntimeSet.MusicSoundEmitter;
            if (musicSoundEmitter is { IsPlaying: true })
            {
                var songToPlay = request.AudioCue.Clips[0];
                if (musicSoundEmitter.Clip == songToPlay)
                {
                    return AudioCueKey.Invalid;
                }

                // Music is already playing, need to fade it out
                startTime = musicSoundEmitter.FadeMusicOut(_fadeMusicOutDuration.Value);
            }

            musicSoundEmitter = SoundEmitterPool.Request();
            musicSoundEmitter.FadeMusicIn(request.AudioCue.Clips[0], request.AudioConfiguration, _fadeMusicInDuration.Value, startTime);
            musicSoundEmitter.OnSoundFinishedPlaying += StopMusicEmitter;

            return AudioCueKey.Invalid; //No need to return a valid key for music
        }

        private void StopMusicEmitter(SoundEmitter soundEmitter)
        {
            soundEmitter.OnSoundFinishedPlaying -= StopMusicEmitter;
            SoundEmitterPool.Return(soundEmitter);
        }
    }
}