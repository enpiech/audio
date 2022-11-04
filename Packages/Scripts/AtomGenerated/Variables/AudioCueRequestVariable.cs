using Audio.AtomGenerated.Events;
using Audio.AtomGenerated.Functions;
using Audio.AtomGenerated.Pairs;
using Audio.Data;
using UnityAtoms;
using UnityEngine;

namespace Audio.AtomGenerated.Variables
{
    /// <summary>
    ///     Variable of type `AudioCueRequest`. Inherits from `EquatableAtomVariable&lt;AudioCueRequest, AudioCueRequestPair,
    ///     AudioCueRequestEvent, AudioCueRequestPairEvent, AudioCueRequestAudioCueRequestFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/AudioCueRequest", fileName = "AudioCueRequestVariable")]
    public sealed class AudioCueRequestVariable : EquatableAtomVariable<AudioCueRequest, AudioCueRequestPair, AudioCueRequestEvent,
        AudioCueRequestPairEvent, AudioCueRequestAudioCueRequestFunction>
    {
    }
}