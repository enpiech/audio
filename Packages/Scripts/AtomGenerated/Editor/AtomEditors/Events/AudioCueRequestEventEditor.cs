#if UNITY_2019_1_OR_NEWER
using Audio.AtomGenerated.Events;
using Audio.Data;
using UnityAtoms.Editor;
using UnityEditor;

namespace Audio.AtomGenerated.Editor.AtomEditors.Events
{
    /// <summary>
    ///     Event property drawer of type `AudioCueRequest`. Inherits from `AtomEventEditor&lt;AudioCueRequest,
    ///     AudioCueRequestEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(AudioCueRequestEvent))]
    public sealed class AudioCueRequestEventEditor : AtomEventEditor<AudioCueRequest, AudioCueRequestEvent>
    {
    }
}
#endif