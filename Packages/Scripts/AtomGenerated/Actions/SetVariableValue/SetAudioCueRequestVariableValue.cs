using Audio.AtomGenerated.Constants;
using Audio.AtomGenerated.Events;
using Audio.AtomGenerated.Functions;
using Audio.AtomGenerated.Pairs;
using Audio.AtomGenerated.References;
using Audio.AtomGenerated.VariableInstancers;
using Audio.AtomGenerated.Variables;
using Audio.Data;
using UnityAtoms;
using UnityEngine;

namespace Audio.AtomGenerated.Actions.SetVariableValue
{
    /// <summary>
    ///     Set variable value Action of type `AudioCueRequest`. Inherits from `SetVariableValue&lt;AudioCueRequest,
    ///     AudioCueRequestPair, AudioCueRequestVariable, AudioCueRequestConstant, AudioCueRequestReference,
    ///     AudioCueRequestEvent, AudioCueRequestPairEvent, AudioCueRequestVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/AudioCueRequest", fileName = "SetAudioCueRequestVariableValue")]
    public sealed class SetAudioCueRequestVariableValue : SetVariableValue<
        AudioCueRequest,
        AudioCueRequestPair,
        AudioCueRequestVariable,
        AudioCueRequestConstant,
        AudioCueRequestReference,
        AudioCueRequestEvent,
        AudioCueRequestPairEvent,
        AudioCueRequestAudioCueRequestFunction,
        AudioCueRequestVariableInstancer>
    {
    }
}