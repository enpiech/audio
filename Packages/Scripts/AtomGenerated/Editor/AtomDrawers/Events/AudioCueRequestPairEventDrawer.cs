#if UNITY_2019_1_OR_NEWER
using Audio.AtomGenerated.Events;
using UnityAtoms.Editor;
using UnityEditor;

namespace Audio.AtomGenerated.Editor.AtomDrawers.Events
{
    /// <summary>
    ///     Event property drawer of type `AudioCueRequestPair`. Inherits from `AtomDrawer&lt;AudioCueRequestPairEvent&gt;`.
    ///     Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AudioCueRequestPairEvent))]
    public class AudioCueRequestPairEventDrawer : AtomDrawer<AudioCueRequestPairEvent>
    {
    }
}
#endif