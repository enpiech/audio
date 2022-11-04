using System;
using Audio.AtomGenerated.Constants;
using Audio.AtomGenerated.Events;
using Audio.AtomGenerated.Functions;
using Audio.AtomGenerated.Pairs;
using Audio.AtomGenerated.VariableInstancers;
using Audio.AtomGenerated.Variables;
using Audio.Data;
using UnityAtoms;

namespace Audio.AtomGenerated.References
{
    /// <summary>
    ///     Reference of type `AudioCueRequest`. Inherits from `EquatableAtomReference&lt;AudioCueRequest, AudioCueRequestPair,
    ///     AudioCueRequestConstant, AudioCueRequestVariable, AudioCueRequestEvent, AudioCueRequestPairEvent,
    ///     AudioCueRequestAudioCueRequestFunction, AudioCueRequestVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AudioCueRequestReference : EquatableAtomReference<
        AudioCueRequest,
        AudioCueRequestPair,
        AudioCueRequestConstant,
        AudioCueRequestVariable,
        AudioCueRequestEvent,
        AudioCueRequestPairEvent,
        AudioCueRequestAudioCueRequestFunction,
        AudioCueRequestVariableInstancer>, IEquatable<AudioCueRequestReference>
    {
        public AudioCueRequestReference()
        {
        }

        public AudioCueRequestReference(AudioCueRequest value) : base(value)
        {
        }

        public bool Equals(AudioCueRequestReference other)
        {
            return base.Equals(other);
        }
    }
}