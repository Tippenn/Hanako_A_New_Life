using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{

    public List<Image> pilihan;
    public Sprite Select;
    public Sprite GaSelect;
    public GameSceneManager gameSceneManager;
    public PauseManager PauseManager;
    public int opsi = 0;
    public AudioManager AudioManager;
    public GameObject optionMenu;
    public GameObject PauseMenu;
    public GameObject creditMenu;

    private void Awake()
    {
        AudioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
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
            if (opsi < 3)
            {
                opsi++;
                ubahpilihan();
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            commitChoice();

        }
    }

    public void commitChoice()
    {
        if (opsi == 0)
            PauseManager.Resume();
        else if (opsi == 1)
            LoadOptions();
        else if (opsi == 2)
            gameSceneManager.LoadMainMenuScene();
        else
            Application.Quit();
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

    private void LoadOptions()
    {
        AudioManager.PlaySFX(AudioManager.Open_Option);
        optionMenu.SetActive(true);
    }

    public void BackinOptionSelected()
    {
        optionMenu.SetActive(false);
        creditMenu.SetActive(false);
        PauseMenu.SetActive(true);
        
    }

    public void BackinCreditSelected()
    {
        optionMenu.SetActive(true);
        creditMenu.SetActive(false);
        PauseMenu.SetActive(false);

    }

    public void CreditSelected()
    {
        optionMenu.SetActive(false);
        creditMenu.SetActive(true); 
        PauseMenu.SetActive(false);
    }

    public void IsSelected(int numb)
    {

        opsi = numb;
        ubahpilihan();
    }
}
