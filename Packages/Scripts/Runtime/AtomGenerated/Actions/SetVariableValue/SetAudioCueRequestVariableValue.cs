using Enpiech.Audio.Runtime.AtomGenerated.Constants;
using Enpiech.Audio.Runtime.AtomGenerated.Events;
using Enpiech.Audio.Runtime.AtomGenerated.Functions;
using Enpiech.Audio.Runtime.AtomGenerated.Pairs;
using Enpiech.Audio.Runtime.AtomGenerated.References;
using Enpiech.Audio.Runtime.AtomGenerated.VariableInstancers;
using Enpiech.Audio.Runtime.AtomGenerated.Variables;
using Enpiech.Audio.Runtime.Data;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Audio.Runtime.AtomGenerated.Actions.SetVariableValue
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