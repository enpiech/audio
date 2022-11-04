using Audio.AtomGenerated.Pairs;
using Audio.AtomGenerated.Variables;
using Audio.Data;
using UnityAtoms.Editor;
using UnityEditor;

namespace Audio.AtomGenerated.Editor.AtomEditors.Variables
{
    /// <summary>
    ///     Variable Inspector of type `AudioCueRequest`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(AudioCueRequestVariable))]
    public sealed class AudioCueRequestVariableEditor : AtomVariableEditor<AudioCueRequest, AudioCueRequestPair>
    {
    }
}