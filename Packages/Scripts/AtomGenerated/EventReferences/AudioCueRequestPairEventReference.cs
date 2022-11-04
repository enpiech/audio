using System;
using Audio.AtomGenerated.EventInstancers;
using Audio.AtomGenerated.Events;
using Audio.AtomGenerated.Pairs;
using Audio.AtomGenerated.VariableInstancers;
using Audio.AtomGenerated.Variables;
using UnityAtoms;

namespace Audio.AtomGenerated.EventReferences
{
    /// <summary>
    ///     Event Reference of type `AudioCueRequestPair`. Inherits from `AtomEventReference&lt;AudioCueRequestPair,
    ///     AudioCueRequestVariable, AudioCueRequestPairEvent, AudioCueRequestVariableInstancer,
    ///     AudioCueRequestPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AudioCueRequestPairEventReference : AtomEventReference<
        AudioCueRequestPair,
        AudioCueRequestVariable,
        AudioCueRequestPairEvent,
        AudioCueRequestVariableInstancer,
        AudioCueRequestPairEventInstancer>, IGetEvent
    {
    }
}