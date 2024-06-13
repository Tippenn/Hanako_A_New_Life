using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingMenuScript : MonoBehaviour
{
    public Slider Master, Music, SFX;
    public AudioMixer mainAudioMixer;

    private void Start()
    {
        Master.value = PlayerPrefs.GetFloat("MasterScroll");
        Music.value = PlayerPrefs.GetFloat("MusicScroll");
        SFX.value = PlayerPrefs.GetFloat("SFXScroll");

    }
    public void ChangeAudioMaster()
    {
        PlayerPrefs.SetFloat("MasterScroll", Master.value);
        mainAudioMixer.SetFloat("MasterVolume",Master.value);
    }

    public void ChangeAudioMusic()
    {
        PlayerPrefs.SetFloat("MusicScroll", Music.value);
        mainAudioMixer.SetFloat("MusicVolume", Music.value);
    }

    public void ChangeAudioSFX()
    {
        PlayerPrefs.SetFloat("SFXScroll", SFX.value);
        mainAudioMixer.SetFloat("SFXVolume", SFX.value);
    }
}
