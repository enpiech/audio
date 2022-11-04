using Enpiech.Audio.Runtime.AtomGenerated.EventReferences;
using Enpiech.Audio.Runtime.AtomGenerated.Events;
using Enpiech.Audio.Runtime.AtomGenerated.Pairs;
using Enpiech.Audio.Runtime.AtomGenerated.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Audio.Runtime.AtomGenerated.EventReferenceListeners
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