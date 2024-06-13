using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public static bool GameisPaused = false;
    public GameObject pausepanel;
    public GameObject Tombol;
    public GameObject pausemenu;
    public GameObject optionmenu;
    public GameObject creditmenu;
    public AudioManager audiomanager;


    private void Awake()
    {
        audiomanager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    private void Start()
    {
        GameisPaused = false;
        pausepanel.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if(GameisPaused == true)
            {
                
                Resume();
            }
            else
            {
                
                Pause();
            }
        }
    }

    public void Resume()
    {
        audiomanager.PlaySFX(audiomanager.Close_Pause);
        GameisPaused = false;
        pausepanel.SetActive(false);
        pausemenu.SetActive(false);
        optionmenu.SetActive(false);
        creditmenu.SetActive(false);
        Tombol.SetActive(true);
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        audiomanager.PlaySFX(audiomanager.Open_Pause);
        GameisPaused = true;
        pausepanel.SetActive(true);
        pausemenu.SetActive(true);
        optionmenu.SetActive(false);
        creditmenu.SetActive(false);
        Tombol.SetActive(false);
        Time.timeScale = 0f;
    }

    public void OnDestroy()
    {
        Time.timeScale = 1f;
    }

}
