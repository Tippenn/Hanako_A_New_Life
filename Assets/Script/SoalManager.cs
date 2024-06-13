using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoalManager : MonoBehaviour
{
    public GameObject WinPanel;
    public GameObject GamePlayPanel;
    public List<string> soal;
    public string SoalRN;
    public int urutansoal = 0;
    public int soaldone = 0;
    public bool ismenang = false;
    public WinManagerToko WMT;
    void Start()
    {
        WinPanel.SetActive(false);
    }

    void Update()
    {
        //Debug.Log(soal.Count);
        if(soaldone == soal.Count && ismenang == false)
        {   
            ismenang = true;
            Menang();
        }
    }

    public void NextSoal()
    {
        urutansoal++;
    }

    public void Menang()
    {
        WMT.HitungAll();
        WinPanel.SetActive(true);
        GamePlayPanel.SetActive(false);
        Debug.Log("Congrats U win");
    }

}
