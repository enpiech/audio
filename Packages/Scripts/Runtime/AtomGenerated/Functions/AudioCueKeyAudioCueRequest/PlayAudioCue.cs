using Enpiech.Audio.Runtime.SoundEmitters;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Audio.Runtime.AtomGenerated.Functions.AudioCueKeyAudioCueRequest
{
    /// <summary>
    ///     Event on which <c>AudioCue</c> components send a message to play SFX and music. <c>AudioManager</c> listens on
    ///     these events, and actually plays the sound.
    /// </summary>
    [EditorIcon("atom-icon-sand")]
    public abstract class PlayAudioCue : AudioCueKeyAudioCueRequestFunction
    {
        [Header("SoundEmitters pool")]
        [SerializeField]
        private SoundEmitterPoolSO _soundEmitterPool = default!;

        [SerializeField]
        private SoundEmitterRuntimeSet _soundEmitterRuntimeSet = default!;

        protected SoundEmitterPoolSO SoundEmitterPool => _soundEmitterPool;

        protected SoundEmitterRuntimeSet SoundEmitterRuntimeSet => _soundEmitterRuntimeSet;
    }
}