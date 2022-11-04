using Audio.Data;
using Audio.SoundEmitters;
using UnityAtoms;
using UnityEngine;

namespace Audio.AtomGenerated.Functions.BoolAudioCueKey
{
    [CreateAssetMenu(menuName = "Unity Atoms/Functions/Audio/FinishSFX (AudioCueKey => bool)")]
    [EditorIcon("atom-icon-sand")]
    public sealed class FinishSFX : BoolAudioCueKeyFunction
    {
        [Header("References")]
        [SerializeField]
        private SoundEmitterRuntimeSet _soundEmitterRuntimeSet = default!;

        public override bool Call(AudioCueKey key)
        {
            var isFoundEmitter = _soundEmitterRuntimeSet.Get(key, out var soundEmitters);
            if (isFoundEmitter)
            {
                foreach (var soundEmitter in soundEmitters)
                {
                    soundEmitter.Finish();
                    soundEmitter.OnSoundFinishedPlaying += _soundEmitterRuntimeSet.StopAndCleanEmitter;
                }
                return true;
            }

            Debug.LogWarning("Finishing an AudioCue was requested, but the AudioCue was not found.");
            return false;
        }
    }
}