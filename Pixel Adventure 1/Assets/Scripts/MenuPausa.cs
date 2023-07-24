using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject audioMenu;
    public AudioSource audioSource;

    private void Start()
    {
        // Make sure audioSource is assigned to the Main Camera's AudioSource
        if (audioSource == null)
        {
            audioSource = Camera.main.GetComponent<AudioSource>();
        }
    }

    // Function to pause the game
    public void pausa()
    {
        Debug.Log("pausa");
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    // Function to continue the game
    public void continuar()
    {
        Debug.Log("continuar");
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    // Function to toggle the audio on/off
    public void AudioJuego()
    {
        if (audioSource != null)
        {
            audioSource.mute = !audioSource.mute;
        }
    }
}
