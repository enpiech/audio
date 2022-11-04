using Audio.AtomGenerated.Events;
using Audio.AtomGenerated.Functions;
using Audio.AtomGenerated.Pairs;
using Audio.AtomGenerated.Variables;
using Audio.Data;
using UnityAtoms;
using UnityEngine;

namespace Audio.AtomGenerated.VariableInstancers
{
    /// <summary>
    ///     Variable Instancer of type `AudioCueRequest`. Inherits from `AtomVariableInstancer&lt;AudioCueRequestVariable,
    ///     AudioCueRequestPair, AudioCueRequest, AudioCueRequestEvent, AudioCueRequestPairEvent,
    ///     AudioCueRequestAudioCueRequestFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/AudioCueRequest Variable Instancer")]
    public class AudioCueRequestVariableInstancer : AtomVariableInstancer<
        AudioCueRequestVariable,
        AudioCueRequestPair,
        AudioCueRequest,
        AudioCueRequestEvent,
        AudioCueRequestPairEvent,
        AudioCueRequestAudioCueRequestFunction>
    {
    }
}