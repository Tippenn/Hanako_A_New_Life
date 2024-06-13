using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChooseModeScript : MonoBehaviour
{
    public List<Button> buttons;
    public List<Image> pilihan;
    public Sprite Select;
    public Sprite GaSelect;
    public GameSceneManager gameSceneManager;
    public AudioManager audioManager;
    public int opsi = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        ubahpilihan();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (opsi > 0)
            {
                opsi--;
                ubahpilihan();
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (opsi < 1)
            {
                opsi++;
                ubahpilihan();
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CommitChoice();
        }
    }

    public void CommitChoice()
    {
        if (opsi == 0)
        {
            audioManager.PlaySFX(audioManager.MainMenu);
            gameSceneManager.LoadStoryModeScene();
        }
        else
        {
            audioManager.PlaySFX(audioManager.ChooseOption);
            gameSceneManager.LoadEndlessModeScene();
        }
    }
    void ubahpilihan()
    {
        foreach (Image image in pilihan)
        {
            TidakPilih(image);
        }
        KenaPilih(pilihan[opsi]);
    }


    void KenaPilih(Image komponen)
    {
        komponen.sprite = Select;
    }

    void TidakPilih(Image komponen)
    {
        komponen.sprite = GaSelect;
    }

    public void EndlessSelected()
    {
        opsi = 1;
        ubahpilihan();
    }

    public void MainModeSelected()
    {
        opsi = 0;
        ubahpilihan();
    }
}

