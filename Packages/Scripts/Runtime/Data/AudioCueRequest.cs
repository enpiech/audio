using System;
using UnityEngine;

namespace Enpiech.Audio.Runtime.Data
{
    [Serializable]
    public struct AudioCueRequest : IEquatable<AudioCueRequest>
    {
        [SerializeField]
        private AudioCueSO _audioCue;

        [SerializeField]
        private AudioConfigurationSO _audioConfiguration;

        [SerializeField]
        private Vector3 _positionInSpace;

        public AudioCueRequest(AudioCueSO audioCue, AudioConfigurationSO audioConfiguration, Vector3 positionInSpace)
        {
            _audioCue = audioCue;
            _audioConfiguration = audioConfiguration;
            _positionInSpace = positionInSpace;
        }

        public AudioCueSO AudioCue => _audioCue;

        public AudioConfigurationSO AudioConfiguration => _audioConfiguration;

        public Vector3 PositionInSpace => _positionInSpace;

        public bool Equals(AudioCueRequest other)
        {
            return _audioCue.Equals(other._audioCue) && _audioConfiguration.Equals(other._audioConfiguration) &&
                   _positionInSpace.Equals(other._positionInSpace);
        }

        public override bool Equals(object? obj)
        {
            return obj is AudioCueRequest other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_audioCue, _audioConfiguration, _positionInSpace);
        }
    }
}