using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private bool isAudioOn = true;

    public void ToggleAudio()
    {
        isAudioOn = !isAudioOn;

        AudioListener.volume = isAudioOn ? 1f : 0f;
    }
}
