using Audio.Data;
using Core;
using UnityEngine;

namespace Audio
{
    /// <summary>
    ///     Event on which <c>AudioCue</c> components send a message to play SFX and music. <c>AudioManager</c> listens on
    ///     these events, and actually plays the sound.
    /// </summary>
    [CreateAssetMenu(menuName = "Events/AudioCue Event Channel")]
    public sealed class AudioCueEventChannelSO : DescriptionBaseSO
    {
        public AudioCueFinishAction? OnAudioCueFinishRequested;
        public AudioCuePlayAction? OnAudioCuePlayRequested;
        public AudioCueStopAction? OnAudioCueStopRequested;

        public AudioCueKey RaisePlayEvent(AudioCueSO audioCue, AudioConfigurationSO audioConfiguration, Vector3 positionInSpace = default)
        {
            if (OnAudioCuePlayRequested != null)
            {
                return OnAudioCuePlayRequested.Invoke(audioCue, audioConfiguration, positionInSpace);
            }

            Debug.LogWarning(
                $"An AudioCue play event was requested  for {audioCue.name}, but nobody picked it up. Check why there is no AudioManager already loaded, and make sure it's listening on this AudioCue Event channel.");
            return AudioCueKey.Invalid;
        }

        public bool RaiseStopEvent(AudioCueKey audioCueKey)
        {
            if (OnAudioCueStopRequested != null)
            {
                return OnAudioCueStopRequested.Invoke(audioCueKey);
            }

            Debug.LogWarning(
                "An AudioCue stop event was requested, but nobody picked it up. Check why there is no AudioManager already loaded, and make sure it\'s listening on this AudioCue Event channel.");
            return false;
        }

        public bool RaiseFinishEvent(AudioCueKey audioCueKey)
        {
            if (OnAudioCueStopRequested != null && OnAudioCueFinishRequested != null)
            {
                return OnAudioCueFinishRequested.Invoke(audioCueKey);
            }

            Debug.LogWarning(
                "An AudioCue finish event was requested, but nobody picked it up. Check why there is no AudioManager already loaded, and make sure it\'s listening on this AudioCue Event channel.");
            return false;
        }
    }
}