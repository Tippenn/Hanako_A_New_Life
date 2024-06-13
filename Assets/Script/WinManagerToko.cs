using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class WinManagerToko : MonoBehaviour
{
    [Header("=====ReferenceYangLain=====")]
    public LetterBehaviourToko LBT;

    [Header("=====Reference=====")]
    public TMP_Text SC;
    public TMP_Text USC;
    public TMP_Text BPM;
    public TMP_Text TS;
    public TMP_Text GameMode;
    public TMP_Text Rank;

    [Header("=====Hitungan=====")]
    public float SChitungan;
    public float USChitungan;
    public float BPMhitungan;
    public float TShitungan;
    public float Waktu;

    public void Start()
    {
        SChitungan = 0;
        USChitungan = 0;
        BPMhitungan = 0;

    }

    private void Update()
    {
        Waktu += Time.deltaTime;
    }
    public void HitungAll()
    {
        Scene scene = SceneManager.GetActiveScene();
        TShitungan = ((BPMhitungan/Waktu)*60) + (SChitungan * 10) + (USChitungan * -5);
        
        if(TShitungan < 50)
        {
            Rank.text = "Mehhh....";
        }
        else if(TShitungan < 150)
        {
            Rank.text = "Not Bad";
        }
        else if(TShitungan < 190)
        {
            Rank.text = "Top 10%";
        }
        else
        {
            Rank.text = "Asian Level";
        }

        if (scene.name != "EndlessMode" || scene.name != "TokoModeScene")
        {
            if (TShitungan < 25)
            {
                Rank.text = "Mehhh....";
            }
            else if (TShitungan < 50)
            {
                Rank.text = "Not Bad";
            }
            else if (TShitungan < 90)
            {
                Rank.text = "Top 10%";
            }
            else
            {
                Rank.text = "Asian Level";
            }
        }
        SC.text = (SChitungan * 10).ToString();
        USC.text = (USChitungan * -5).ToString();
        BPM.text = ((BPMhitungan / Waktu) * 60).ToString("F2");
        TS.text = TShitungan.ToString("F2");

        if(scene.name == "TokoModeScene")
        {
            GameMode.text = "Ending Story Mode";
        }
        else if (scene.name == "EndlessMode")
        {
            GameMode.text = "Endless Mode";
        }
        else
        {
            GameMode.text = "Study Mode";
        }
        
    }
}
