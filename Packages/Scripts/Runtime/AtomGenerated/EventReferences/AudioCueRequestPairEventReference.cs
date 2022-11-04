using System;
using Enpiech.Audio.Runtime.AtomGenerated.EventInstancers;
using Enpiech.Audio.Runtime.AtomGenerated.Events;
using Enpiech.Audio.Runtime.AtomGenerated.Pairs;
using Enpiech.Audio.Runtime.AtomGenerated.VariableInstancers;
using Enpiech.Audio.Runtime.AtomGenerated.Variables;
using UnityAtoms;

namespace Enpiech.Audio.Runtime.AtomGenerated.EventReferences
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