using Audio.Data;
using UnityEngine;

namespace Audio
{
    public delegate AudioCueKey AudioCuePlayAction(AudioCueSO audioCue, AudioConfigurationSO audioConfiguration, Vector3 positionInSpace);
}