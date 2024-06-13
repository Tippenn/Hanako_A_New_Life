using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SoalManagerEndless : MonoBehaviour
{
    public GameObject WinPanel;
    public GameObject GamePlayPanel;
    public WinManagerToko WMT;
    public TMP_Text time;
    public float timeleft = 120f;
    public List<string> soal;
    public bool ismenang = false;
    // Start is called before the first frame update
    void Start()
    {
        WinPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        time.text = Formattime(timeleft);
        if (timeleft < 0f && ismenang == false)
        {
            ismenang = true;
            Menang();
        }
    }
    public string Formattime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);
        return string.Format("{0:00}:{1:00}",minutes,seconds);
    }

    public void Menang()
    {
        WMT.HitungAll();
        WinPanel.SetActive(true);
        GamePlayPanel.SetActive(false);
        Debug.Log("Congrats U win");
    }
}
