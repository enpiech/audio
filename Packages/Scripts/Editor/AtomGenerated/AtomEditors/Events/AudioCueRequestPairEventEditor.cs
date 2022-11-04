#if UNITY_2019_1_OR_NEWER
using Enpiech.Audio.Runtime.AtomGenerated.Events;
using Enpiech.Audio.Runtime.AtomGenerated.Pairs;
using UnityAtoms.Editor;
using UnityEditor;

namespace Enpiech.Audio.Editor.AtomGenerated.AtomEditors.Events
{
    /// <summary>
    ///     Event property drawer of type `AudioCueRequestPair`. Inherits from `AtomEventEditor&lt;AudioCueRequestPair,
    ///     AudioCueRequestPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(AudioCueRequestPairEvent))]
    public sealed class AudioCueRequestPairEventEditor : AtomEventEditor<AudioCueRequestPair, AudioCueRequestPairEvent>
    {
    }
}
#endif