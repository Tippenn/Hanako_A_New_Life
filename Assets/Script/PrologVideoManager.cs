using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PrologVideoManager : MonoBehaviour
{
    public VideoPlayer player;
    public GameSceneManager gameSceneManager;
    public AudioManager audioManager;
    public AudioSource audioSource;
    // Update is called once per frame

    private void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();

        audioManager.MusicSource.mute = true;
        if (player != null)
        {
            player.loopPointReached += VideoEnds;
        }
    }

    public void VideoEnds(VideoPlayer vp)
    {
        audioManager.MusicSource.mute = false;
        gameSceneManager.LoadingScene("TutorialScene");
    }

    private void OnDestroy()
    {
        if (player != null)
        {
            player.loopPointReached -= VideoEnds;
        }
    }
}
