using Enpiech.Audio.Runtime.Data;
using UnityEngine;

namespace Enpiech.Audio.Runtime
{
    public delegate AudioCueKey AudioCuePlayAction(AudioCueSO audioCue, AudioConfigurationSO audioConfiguration, Vector3 positionInSpace);
}