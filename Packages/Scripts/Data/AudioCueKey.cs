using System;

namespace Audio.Data
{
    [Serializable]
    public readonly struct AudioCueKey
    {
        public static AudioCueKey Invalid = new(-1, null);
        private readonly AudioCueSO? _audioCue;

        private readonly int _value;

        internal AudioCueKey(int value, AudioCueSO? audioCue)
        {
            _value = value;
            _audioCue = audioCue;
        }

        public override bool Equals(object obj)
        {
            return obj is AudioCueKey x && _value == x._value && _audioCue == x._audioCue;
        }

        public override int GetHashCode()
        {
            if (_audioCue == null)
            {
                return _value.GetHashCode();
            }
            return _value.GetHashCode() ^ _audioCue.GetHashCode();
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