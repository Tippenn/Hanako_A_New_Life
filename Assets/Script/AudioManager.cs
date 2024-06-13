using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    public AudioSource MusicSource;
    public AudioSource SFXSource;

    [Header("Audio Clip")]
    [Header("BGM")]
    public AudioClip BGM;
    [Header("GamePlay")]
    public AudioClip Tekan;
    public AudioClip Lepas;
    [Header("PauseMenu")]
    public AudioClip Open_Pause;
    public AudioClip Close_Pause;
    public AudioClip Open_Option;
    [Header("MainMenu")]
    public AudioClip MainMenu;
    public AudioClip ChooseOption;
    [Header("SplashScreen")]
    public AudioClip Breeze;

    public static AudioManager instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        MusicSource.clip = BGM;
        MusicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
