using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public List<Image> pilihan;
    public AudioManager audioManager;
    public Sprite Select;
    public Sprite GaSelect;
    public GameSceneManager gameSceneManager;
    private int opsi = 0;

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
            if (opsi < 2)
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
        audioManager.PlaySFX(audioManager.MainMenu);
        if (opsi == 0)
            gameSceneManager.LoadChooseModeScene();
        else if (opsi == 1)
            gameSceneManager.LoadOptionScene();
        else
            gameSceneManager.LoadQuit();
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

    public void PlaySelected()
    {
        opsi = 0;
        ubahpilihan();
    }

    public void OptionSelected()
    {
        opsi = 1;
        ubahpilihan();
    }

    public void QuitSelected()
    {
        opsi = 2;
        ubahpilihan();
    }
}
