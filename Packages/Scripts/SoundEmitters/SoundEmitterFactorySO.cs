﻿using Core.Factory;
using UnityEngine;

namespace Audio.SoundEmitters
{
    [CreateAssetMenu(fileName = "Factory_SoundEmitter", menuName = "Factory/SoundEmitter")]
    public sealed class SoundEmitterFactorySO : FactorySO<SoundEmitter>
    {
        [SerializeField]
        private SoundEmitter _prefab = default!;

        public override SoundEmitter Create()
        {
            return Instantiate(_prefab);
        }
    }
}