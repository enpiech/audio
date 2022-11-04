using System;
using Enpiech.Audio.Runtime.AtomGenerated.EventInstancers;
using Enpiech.Audio.Runtime.AtomGenerated.Events;
using Enpiech.Audio.Runtime.AtomGenerated.VariableInstancers;
using Enpiech.Audio.Runtime.AtomGenerated.Variables;
using Enpiech.Audio.Runtime.Data;
using UnityAtoms;

namespace Enpiech.Audio.Runtime.AtomGenerated.EventReferences
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