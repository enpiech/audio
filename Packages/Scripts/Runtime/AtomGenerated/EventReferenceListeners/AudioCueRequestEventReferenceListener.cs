using Enpiech.Audio.Runtime.AtomGenerated.EventReferences;
using Enpiech.Audio.Runtime.AtomGenerated.Events;
using Enpiech.Audio.Runtime.AtomGenerated.UnityEvents;
using Enpiech.Audio.Runtime.Data;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Audio.Runtime.AtomGenerated.EventReferenceListeners
{
    /// <summary>
    ///     Event Reference Listener of type `AudioCueRequest`. Inherits from `AtomEventReferenceListener&lt;AudioCueRequest,
    ///     AudioCueRequestEvent, AudioCueRequestEventReference, AudioCueRequestUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/AudioCueRequest Event Reference Listener")]
    public sealed class AudioCueRequestEventReferenceListener : AtomEventReferenceListener<
        AudioCueRequest,
        AudioCueRequestEvent,
        AudioCueRequestEventReference,
        AudioCueRequestUnityEvent>
    {
    }
}