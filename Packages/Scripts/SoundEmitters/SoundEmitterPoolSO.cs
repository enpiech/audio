using Core.Factory;
using Core.Pool;
using UnityEngine;

namespace Audio.SoundEmitters
{
    [CreateAssetMenu(fileName = "NewSoundEmitterPool", menuName = "Pool/SoundEmitter Pool")]
    public sealed class SoundEmitterPoolSO : ComponentPoolSO<SoundEmitter>
    {
        [SerializeField]
        private SoundEmitterFactorySO _factory = default!;

        public override IFactory<SoundEmitter> Factory
        {
            get => _factory;
            set => _factory = (value as SoundEmitterFactorySO)!;
        }
    }
}