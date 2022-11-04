using Audio.AtomGenerated.EventReferences;
using Audio.AtomGenerated.Events;
using Audio.AtomGenerated.UnityEvents;
using Audio.Data;
using UnityAtoms;
using UnityEngine;

namespace Audio.AtomGenerated.EventReferenceListeners
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