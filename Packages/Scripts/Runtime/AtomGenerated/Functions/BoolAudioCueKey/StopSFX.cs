using Enpiech.Audio.Runtime.Data;
using Enpiech.Audio.Runtime.SoundEmitters;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Audio.Runtime.AtomGenerated.Functions.BoolAudioCueKey
{
    [CreateAssetMenu(menuName = "Unity Atoms/Functions/Audio/StopSFX (AudioCueKey => bool)")]
    [EditorIcon("atom-icon-sand")]
    public sealed class StopSFX : BoolAudioCueKeyFunction
    {
        [Header("References")]
        [SerializeField]
        private SoundEmitterRuntimeSet _soundEmitterRuntimeSet = default!;

        public override bool Call(AudioCueKey key)
        {
            var isFoundEmitter = _soundEmitterRuntimeSet.Get(key, out var soundEmitters);
            if (!isFoundEmitter)
            {
                return false;
            }

            foreach (var soundEmitter in soundEmitters)
            {
                _soundEmitterRuntimeSet.StopAndCleanEmitter(soundEmitter);
            }

            _soundEmitterRuntimeSet.Remove(key);
            return true;
        }
    }
}