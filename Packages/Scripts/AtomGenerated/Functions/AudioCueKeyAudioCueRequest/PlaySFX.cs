using Audio.Data;
using Audio.SoundEmitters;
using UnityAtoms;
using UnityEngine;

namespace Audio.AtomGenerated.Functions.AudioCueKeyAudioCueRequest
{
    /// <summary>
    ///     Event on which <c>AudioCue</c> components send a message to play SFX and music. <c>AudioManager</c> listens on
    ///     these events, and actually plays the sound.
    /// </summary>
    /// [EditorIcon("atom-icon-sand")]
    [EditorIcon("atom-icon-sand")]
    [CreateAssetMenu(menuName = "Unity Atoms/Functions/Adio/PlaySFX (AudioCueRequest => AudioCueKey)")]
    public abstract class PlaySFX : PlayAudioCue
    {
        public override AudioCueKey Call(AudioCueRequest request)
        {
            var clipsToPlay = request.AudioCue.Clips;
            var soundEmitterArray = new SoundEmitter[clipsToPlay.Length];

            var nOfClips = clipsToPlay.Length;
            for (var i = 0; i < nOfClips; i++)
            {
                soundEmitterArray[i] = SoundEmitterPool.Request();
                if (soundEmitterArray[i] == null)
                {
                    continue;
                }

                soundEmitterArray[i].PlayAudioClip(clipsToPlay[i], request.AudioConfiguration, request.AudioCue.IsLooping,
                    request.PositionInSpace);
                if (!request.AudioCue.IsLooping)
                {
                    soundEmitterArray[i].OnSoundFinishedPlaying += SoundEmitterRuntimeSet.StopAndCleanEmitter;
                }
            }

            return SoundEmitterRuntimeSet.Add(request.AudioCue, soundEmitterArray);
        }
    }
}