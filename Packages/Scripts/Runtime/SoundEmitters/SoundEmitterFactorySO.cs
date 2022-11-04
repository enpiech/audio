using Enpiech.Core.Runtime.Factory;
using UnityEngine;

namespace Enpiech.Audio.Runtime.SoundEmitters
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