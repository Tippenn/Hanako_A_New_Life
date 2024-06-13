using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoRemover : MonoBehaviour
{

    public VideoPlayer player;
    public GameObject video;
    private void Start()
    {
        if (player != null)
        {
            player.loopPointReached += removevideo;
        }
    }

    public void removevideo(VideoPlayer vp)
    {
        video.SetActive(false);
    }

    private void OnDestroy()
    {
        if (player != null)
        {
            player.loopPointReached -= removevideo;
        }
    }
}
