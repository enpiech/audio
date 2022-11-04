using System;
using UnityEngine;

namespace Enpiech.Audio.Runtime.Data
{
    /// <summary>
    ///     A collection of audio clips that are played in parallel, and support randomisation.
    /// </summary>
    [CreateAssetMenu(menuName = "Audio/Audio Cue")]
    public sealed class AudioCueSO : ScriptableObject
    {
        [SerializeField]
        private bool _isLooping;

        [SerializeField]
        private AudioClipsGroup[] _audioClipGroups = Array.Empty<AudioClipsGroup>();

        public AudioClip[] Clips
        {
            get
            {
                var numberOfClips = _audioClipGroups.Length;
                var resultingClips = new AudioClip[numberOfClips];

                for (var i = 0; i < numberOfClips; i++)
                {
                    resultingClips[i] = _audioClipGroups[i].NextClip;
                }

                return resultingClips;
            }
        }

        public bool IsLooping => _isLooping;
    }
}