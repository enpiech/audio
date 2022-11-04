using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Audio
{
    /// <summary>
    ///     Represents a group of AudioClips that can be treated as one, and provides automatic randomisation or sequencing
    ///     based on the <c>SequenceMode</c> value.
    /// </summary>
    [Serializable]
    public class AudioClipsGroup
    {
        [SerializeField]
        private SequenceMode _sequenceMode = SequenceMode.RandomNoImmediateRepeat;

        [SerializeField]
        private AudioClip[] _audioClips = default!;

        private int _lastClipPlayed = -1;

        private int _nextClipToPlay = -1;

        /// <summary>
        ///     Chooses the next clip in the sequence, either following the order or randomly.
        /// </summary>
        /// <value>A reference to an AudioClip</value>
        public AudioClip NextClip
        {
            get
            {
                // Fast out if there is only one clip to play
                if (_audioClips.Length == 1)
                {
                    return _audioClips[0];
                }

                if (_nextClipToPlay == -1)
                {
                    // Index needs to be initialised: 0 if Sequential, random if otherwise
                    _nextClipToPlay = _sequenceMode == SequenceMode.Sequential ? 0 : Random.Range(0, _audioClips.Length);
                    return _audioClips[_nextClipToPlay];
                }

                switch (_sequenceMode)
                {
                    case SequenceMode.Random:
                        _nextClipToPlay = Random.Range(0, _audioClips.Length);
                        break;
                    case SequenceMode.RandomNoImmediateRepeat:
                    {
                        do
                        {
                            _nextClipToPlay = Random.Range(0, _audioClips.Length);
                        } while (_nextClipToPlay == _lastClipPlayed);
                        break;
                    }
                    case SequenceMode.Sequential:
                        _nextClipToPlay = (int)Mathf.Repeat(++_nextClipToPlay, _audioClips.Length);
                        break;
                }

                _lastClipPlayed = _nextClipToPlay;

                return _audioClips[_nextClipToPlay];
            }
        }
    }
}