using Enpiech.Audio.Runtime.Data;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Audio.Runtime.Action
{
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Audio/Play SFX", fileName = "AC_PlaySFX")]
    public sealed class PlaySFXAction : AtomAction
    {
        [Header("Config")]
        [SerializeField]
        private AudioCueSO _audioCue = default!;

        [SerializeField]
        private AudioConfigurationSO _config = default!;

        [Header("Broadcasting on")]
        [SerializeField]
        private AudioCueEventChannelSO _playSfxAudioCueEventChannel = default!;

        public override void Do()
        {
            base.Do();
            _playSfxAudioCueEventChannel.RaisePlayEvent(_audioCue, _config);
        }
    }
}