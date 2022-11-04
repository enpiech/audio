#if UNITY_2019_1_OR_NEWER
using Enpiech.Audio.Runtime.AtomGenerated.Events;
using Enpiech.Audio.Runtime.Data;
using UnityAtoms.Editor;
using UnityEditor;

namespace Enpiech.Audio.Editor.AtomGenerated.AtomEditors.Events
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