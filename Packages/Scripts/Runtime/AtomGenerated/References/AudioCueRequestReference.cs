using System;
using Enpiech.Audio.Runtime.AtomGenerated.Constants;
using Enpiech.Audio.Runtime.AtomGenerated.Events;
using Enpiech.Audio.Runtime.AtomGenerated.Functions;
using Enpiech.Audio.Runtime.AtomGenerated.Pairs;
using Enpiech.Audio.Runtime.AtomGenerated.VariableInstancers;
using Enpiech.Audio.Runtime.AtomGenerated.Variables;
using Enpiech.Audio.Runtime.Data;
using UnityAtoms;

namespace Enpiech.Audio.Runtime.AtomGenerated.References
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