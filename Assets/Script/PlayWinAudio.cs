using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWinAudio : MonoBehaviour
{
    public AudioManager audioManager;
    public AudioSource audioSource;
    public GameSceneManager gameSceneManager;
    void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        audioSource.loop = true;
        audioSource.clip = audioManager.Breeze;
        audioSource.Play();
    }

    public void UnloopSFX()
    {
        audioSource.loop = false;
        audioSource.Stop();
        gameSceneManager.LoadMainMenuScene();
    }
}
