using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Audio;

namespace Enpiech.Audio.Runtime.Data
{
    //TODO: Check which settings we really need at this level
    [CreateAssetMenu(menuName = "Audio/Audio Configuration")]
    public sealed class AudioConfigurationSO : ScriptableObject
    {
        [SerializeField]
        private AudioMixerGroup? _outputAudioMixerGroup;

        [Tooltip("Simplified management of priority levels (values are counterintuitive, see enum below)")]
        [SerializeField]
        private PriorityLevel _priorityLevel = PriorityLevel.Standard;

        [Foldout("Sound properties")]
        [SerializeField]
        private bool _mute;

        [Foldout("Sound properties")]
        [Range(0f, 1f)]
        [SerializeField]
        private float _volume = 1f;

        [Foldout("Sound properties")]
        [Range(-3f, 3f)]
        [SerializeField]
        private float _pitch = 1f;

        [Foldout("Sound properties")]
        [Range(-1f, 1f)]
        [SerializeField]
        private float _panStereo;

        [Foldout("Sound properties")]
        [Range(0f, 1.1f)]
        [SerializeField]
        private float _reverbZoneMix = 1f;

        [Foldout("Sound properties")]
        [Header("Spatialisation")]
        [Range(0f, 1f)]
        [SerializeField]
        private float _spatialBlend = 1f;

        [Foldout("Sound properties")]
        [SerializeField]
        private AudioRolloffMode _rolloffMode = AudioRolloffMode.Logarithmic;

        [Foldout("Sound properties")]
        [Range(0.01f, 5f)]
        [SerializeField]
        private float _minDistance = 0.1f;

        [Foldout("Sound properties")]
        [Range(5f, 100f)]
        [SerializeField]
        private float _maxDistance = 50f;

        [Foldout("Sound properties")]
        [Range(0, 360)]
        [SerializeField]
        private int _spread;

        [Foldout("Sound properties")]
        [Range(0f, 5f)]
        [SerializeField]
        private float _dopplerLevel = 1f;

        [Foldout("Ignores")]
        [SerializeField]
        private bool _bypassEffects;

        [Foldout("Ignores")]
        [SerializeField]
        private bool _bypassListenerEffects;

        [Foldout("Ignores")]
        [SerializeField]
        private bool _bypassReverbZones;

        [Foldout("Ignores")]
        [SerializeField]
        private bool _ignoreListenerVolume;

        [Foldout("Ignores")]
        [SerializeField]
        private bool _ignoreListenerPause;

        private int Priority => (int)_priorityLevel;

        public float Volume => _volume;

        public void ApplyTo(AudioSource audioSource)
        {
            audioSource.outputAudioMixerGroup = _outputAudioMixerGroup;
            audioSource.mute = _mute;
            audioSource.bypassEffects = _bypassEffects;
            audioSource.bypassListenerEffects = _bypassListenerEffects;
            audioSource.bypassReverbZones = _bypassReverbZones;
            audioSource.priority = Priority;
            audioSource.volume = _volume;
            audioSource.pitch = _pitch;
            audioSource.panStereo = _panStereo;
            audioSource.spatialBlend = _spatialBlend;
            audioSource.reverbZoneMix = _reverbZoneMix;
            audioSource.dopplerLevel = _dopplerLevel;
            audioSource.spread = _spread;
            audioSource.rolloffMode = _rolloffMode;
            audioSource.minDistance = _minDistance;
            audioSource.maxDistance = _maxDistance;
            audioSource.ignoreListenerVolume = _ignoreListenerVolume;
            audioSource.ignoreListenerPause = _ignoreListenerPause;
        }

        private enum PriorityLevel
        {
            Highest = 0,
            High = 64,
            Standard = 128,
            Low = 194,
            VeryLow = 256
        }
    }
}