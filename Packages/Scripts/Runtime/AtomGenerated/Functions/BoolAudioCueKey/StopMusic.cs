using Enpiech.Audio.Runtime.Data;
using Enpiech.Audio.Runtime.SoundEmitters;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Audio.Runtime.AtomGenerated.Functions.BoolAudioCueKey
{
    [CreateAssetMenu(menuName = "Unity Atoms/Functions/Audio/StopMusic (AudioCueKey => bool)")]
    [EditorIcon("atom-icon-sand")]
    public sealed class StopMusic : BoolAudioCueKeyFunction
    {
        [Header("References")]
        [SerializeField]
        private SoundEmitterRuntimeSet _soundEmitterRuntimeSet = default!;

        public override bool Call(AudioCueKey key)
        {
            var musicSoundEmitter = _soundEmitterRuntimeSet.MusicSoundEmitter;
            if (musicSoundEmitter == null || !musicSoundEmitter.IsPlaying)
            {
                return false;
            }

            musicSoundEmitter.Stop();
            return true;
        }
    }
}