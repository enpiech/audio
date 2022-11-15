using System;

namespace Enpiech.Audio.Runtime.Data
{
    [Serializable]
    public readonly struct AudioCueKey : IEquatable<AudioCueKey>
    {
        public static AudioCueKey Invalid = new(-1, null);
        private readonly AudioCueSO? _audioCue;

        private readonly int _value;

        internal AudioCueKey(int value, AudioCueSO? audioCue)
        {
            _value = value;
            _audioCue = audioCue;
        }

        public bool Equals(AudioCueKey other)
        {
            return Equals(_audioCue, other._audioCue) && _value == other._value;
        }

        public override bool Equals(object obj)
        {
            return obj is AudioCueKey other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_audioCue, _value);
        }

        public static bool operator ==(AudioCueKey x, AudioCueKey y)
        {
            return x._value == y._value && x._audioCue == y._audioCue;
        }

        public static bool operator !=(AudioCueKey x, AudioCueKey y)
        {
            return !(x == y);
        }
    }
}