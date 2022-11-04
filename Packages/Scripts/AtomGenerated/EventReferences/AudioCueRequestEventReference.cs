using System;
using Audio.AtomGenerated.EventInstancers;
using Audio.AtomGenerated.Events;
using Audio.AtomGenerated.VariableInstancers;
using Audio.AtomGenerated.Variables;
using Audio.Data;
using UnityAtoms;

namespace Audio.AtomGenerated.EventReferences
{
    /// <summary>
    ///     Event Reference of type `AudioCueRequest`. Inherits from `AtomEventReference&lt;AudioCueRequest,
    ///     AudioCueRequestVariable, AudioCueRequestEvent, AudioCueRequestVariableInstancer, AudioCueRequestEventInstancer&gt;
    ///     `.
    /// </summary>
    [Serializable]
    public sealed class AudioCueRequestEventReference : AtomEventReference<
        AudioCueRequest,
        AudioCueRequestVariable,
        AudioCueRequestEvent,
        AudioCueRequestVariableInstancer,
        AudioCueRequestEventInstancer>, IGetEvent
    {
    }
}