using Audio.AtomGenerated.EventReferences;
using Audio.AtomGenerated.Events;
using Audio.AtomGenerated.Pairs;
using Audio.AtomGenerated.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace Audio.AtomGenerated.EventReferenceListeners
{
    /// <summary>
    ///     Event Reference Listener of type `AudioCueRequestPair`. Inherits from `AtomEventReferenceListener&lt;
    ///     AudioCueRequestPair, AudioCueRequestPairEvent, AudioCueRequestPairEventReference, AudioCueRequestPairUnityEvent&gt;
    ///     `.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/AudioCueRequestPair Event Reference Listener")]
    public sealed class AudioCueRequestPairEventReferenceListener : AtomEventReferenceListener<
        AudioCueRequestPair,
        AudioCueRequestPairEvent,
        AudioCueRequestPairEventReference,
        AudioCueRequestPairUnityEvent>
    {
    }
}