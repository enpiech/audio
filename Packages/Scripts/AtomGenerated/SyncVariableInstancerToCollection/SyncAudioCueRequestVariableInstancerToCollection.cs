using Audio.AtomGenerated.VariableInstancers;
using Audio.AtomGenerated.Variables;
using Audio.Data;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Audio.AtomGenerated.SyncVariableInstancerToCollection
{
    /// <summary>
    ///     Adds Variable Instancer's Variable of type AudioCueRequest to a Collection or List on OnEnable and removes it on
    ///     OnDestroy.
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync AudioCueRequest Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncAudioCueRequestVariableInstancerToCollection : SyncVariableInstancerToCollection<AudioCueRequest, AudioCueRequestVariable,
        AudioCueRequestVariableInstancer>
    {
    }
}