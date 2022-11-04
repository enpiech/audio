#if UNITY_2019_1_OR_NEWER
using Audio.AtomGenerated.Events;
using UnityAtoms.Editor;
using UnityEditor;

namespace Audio.AtomGenerated.Editor.AtomDrawers.Events
{
    /// <summary>
    ///     Event property drawer of type `AudioCueRequest`. Inherits from `AtomDrawer&lt;AudioCueRequestEvent&gt;`. Only
    ///     availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AudioCueRequestEvent))]
    public class AudioCueRequestEventDrawer : AtomDrawer<AudioCueRequestEvent>
    {
    }
}
#endif