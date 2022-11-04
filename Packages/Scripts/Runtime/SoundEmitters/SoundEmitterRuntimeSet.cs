using System;
using System.Collections.Generic;
using Core;
using Enpiech.Audio.Runtime.Data;
using UnityEngine;

namespace Enpiech.Audio.Runtime.SoundEmitters
{
    public sealed class SoundEmitterRuntimeSet : DescriptionBaseSO
    {
        [SerializeField]
        private SoundEmitterPoolSO _soundEmitterPool = default!;

        private readonly List<AudioCueKey> _emittersKey;
        private readonly List<SoundEmitter[]> _emittersList;
        private int _nextUniqueKey;

        public SoundEmitterRuntimeSet()
        {
            _emittersKey = new List<AudioCueKey>();
            _emittersList = new List<SoundEmitter[]>();
        }

        public SoundEmitter? MusicSoundEmitter { get; set; }

        public AudioCueKey GetKey(AudioCueSO cue)
        {
            return new AudioCueKey(_nextUniqueKey++, cue);
        }

        public void Add(AudioCueKey key, SoundEmitter[] emitter)
        {
            _emittersKey.Add(key);
            _emittersList.Add(emitter);
        }

        public AudioCueKey Add(AudioCueSO cue, SoundEmitter[] emitter)
        {
            var emitterKey = GetKey(cue);

            _emittersKey.Add(emitterKey);
            _emittersList.Add(emitter);

            return emitterKey;
        }

        public bool Get(AudioCueKey key, out SoundEmitter[] emitter)
        {
            var index = _emittersKey.FindIndex(x => x == key);

            if (index < 0)
            {
                emitter = Array.Empty<SoundEmitter>();
                return false;
            }

            emitter = _emittersList[index];
            return true;
        }

        public bool Remove(AudioCueKey key)
        {
            var index = _emittersKey.FindIndex(x => x == key);
            return RemoveAt(index);
        }

        private bool RemoveAt(int index)
        {
            if (index < 0)
            {
                return false;
            }

            _emittersKey.RemoveAt(index);
            _emittersList.RemoveAt(index);

            return true;
        }

        public void StopAndCleanEmitter(SoundEmitter soundEmitter)
        {
            if (!soundEmitter.IsLooping)
            {
                soundEmitter.OnSoundFinishedPlaying -= StopAndCleanEmitter;
            }

            soundEmitter.Stop();
            _soundEmitterPool.Return(soundEmitter);

            //TODO: is the above enough?
            //_soundEmitterVault.Remove(audioCueKey); is never called if StopAndClean is called after a Finish event
            //How is the key removed from the vault?
        }
    }
}