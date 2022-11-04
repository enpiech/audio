using System;
using Audio.Data;
using UnityAtoms;
using UnityEngine;

namespace Audio.AtomGenerated.Pairs
{
    /// <summary>
    ///     IPair of type `&lt;AudioCueRequest&gt;`. Inherits from `IPair&lt;AudioCueRequest&gt;`.
    /// </summary>
    [Serializable]
    public struct AudioCueRequestPair : IPair<AudioCueRequest>
    {
        [SerializeField]
        private AudioCueRequest _item1;

        [SerializeField]
        private AudioCueRequest _item2;

        public AudioCueRequest Item1
        {
            get => _item1;
            set => _item1 = value;
        }

        public AudioCueRequest Item2
        {
            get => _item2;
            set => _item2 = value;
        }

        public void Deconstruct(out AudioCueRequest item1, out AudioCueRequest item2)
        {
            item1 = Item1;
            item2 = Item2;
        }
    }
}