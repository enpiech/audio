using System;
using Audio.Data;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace Audio.SoundEmitters
{
    [RequireComponent(typeof(AudioSource))]
    public sealed class SoundEmitter : MonoBehaviour
    {
        [SerializeField]
        private AudioSource _audioSource = default!;

        /// <summary>
        ///     Used to check which music track is being played.
        /// </summary>
        public AudioClip Clip => _audioSource.clip;

        public bool IsPlaying => _audioSource.isPlaying;

        public bool IsLooping => _audioSource.loop;

        /// <summary>
        ///     Picked up by the AudioController
        /// </summary>
        public event UnityAction<SoundEmitter> OnSoundFinishedPlaying = _ => { };

        /// <summary>
        ///     Instructs the AudioSource to play a single clip, with optional looping, in a position in 3D space.
        /// </summary>
        public void PlayAudioClip(AudioClip clip, AudioConfigurationSO settings, bool hasToLoop, Vector3 position = default)
        {
            _audioSource.clip = clip;
            settings.ApplyTo(_audioSource);
            _audioSource.transform.position = position;
            _audioSource.loop = hasToLoop;
            _audioSource.time = 0f; //Reset in case this AudioSource is being reused for a short SFX after being used for a long music track
            _audioSource.Play();

            if (!hasToLoop)
            {
                FinishedPlaying(clip.length).Forget();
            }
        }

        public void FadeMusicIn(AudioClip musicClip, AudioConfigurationSO settings, float duration, float startTime = 0f)
        {
            PlayAudioClip(musicClip, settings, true);
            _audioSource.volume = 0f;

            //Start the clip at the same time the previous one left, if length allows
            //TODO: find a better way to sync fading songs
            if (startTime <= _audioSource.clip.length)
            {
                _audioSource.time = startTime;
            }

            _audioSource.DOFade(settings.Volume, duration);
        }

        public float FadeMusicOut(float duration)
        {
            _audioSource.DOFade(0f, duration).onComplete += OnFadeOutComplete;
            return _audioSource.time;
        }

        private void OnFadeOutComplete()
        {
            NotifyBeingDone();
        }

        /// <summary>
        ///     Used when the game is unpaused, to pick up SFX from where they left.
        /// </summary>
        public void Resume()
        {
            _audioSource.Play();
        }

        /// <summary>
        ///     Used when the game is paused.
        /// </summary>
        public void Pause()
        {
            _audioSource.Pause();
        }

        public void Stop()
        {
            _audioSource.Stop();
        }

        public void Finish()
        {
            if (!_audioSource.loop)
            {
                return;
            }

            _audioSource.loop = false;
            var timeRemaining = _audioSource.clip.length - _audioSource.time;
            FinishedPlaying(timeRemaining).Forget();
        }

        private async UniTaskVoid FinishedPlaying(float clipLength)
        {
            await UniTask.Delay(TimeSpan.FromSeconds(clipLength));
            NotifyBeingDone();
        }

        private void NotifyBeingDone()
        {
            OnSoundFinishedPlaying.Invoke(this);
        }
    }
}