using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    private int phase = 0;
    public List<GameObject> Tahap;
    public GameObject tutorialpanel;
    public GameObject gameplaypanel;
    public PauseManager pausemanager;

    void Start()
    {
        DisableGameplay();
        DisablePause();
        CheckForPhase();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            addPhase();
        }
    }
    public void addPhase()
    {
        phase++;
        CheckForPhase();
    }
    public void CheckForPhase()
    {
        if(phase < 6)
        UpdatePhase();

        if (phase == 6)
        {
            EndTutorial();
        }
    }

    void DisableGameplay()
    {
        gameplaypanel.SetActive(false);
    }

    void DisablePause()
    {
        pausemanager.enabled = false;
    }

    void UpdatePhase()
    {
        foreach (GameObject go in Tahap)
        {
            go.SetActive(false);
        }
        Tahap[phase].SetActive(true);

    }

    void EndTutorial()
    {
        PlayerPrefs.SetInt("pernah", 1);
        tutorialpanel.SetActive(false);
        gameplaypanel.SetActive(true);
        pausemanager.enabled = true;
    }
}
