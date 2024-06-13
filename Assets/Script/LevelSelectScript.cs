using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectScript : MonoBehaviour
{
    public List<Image> pilihan;
    public Sprite Select;
    public Sprite GaSelect;
    public GameSceneManager gameSceneManager;
    public AudioManager audioManager;
    public int opsi = 0;
    public int unlock;

    // Start is called before the first frame update
    void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        unlock = PlayerPrefs.GetInt("LevelKebuka");
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
            CommitChoice();
        }
    }

    public void CommitChoice()
    {
        audioManager.PlaySFX(audioManager.ChooseOption);
        if (opsi == 0)
            gameSceneManager.LoadingScene("Level1Scene");
        else if (opsi == 1)
            gameSceneManager.LoadingScene("Level2Scene");
        else if (opsi == 2)
            gameSceneManager.LoadingScene("Level3Scene");
        else
            gameSceneManager.LoadingScene("TokoModeScene");

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

    public void SomethingSelected(int pilihan)
    {
        opsi = pilihan;
        ubahpilihan();
    }
}
