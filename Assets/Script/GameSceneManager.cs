using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void LoadChooseModeScene()
    {
        int udahtutorial = PlayerPrefs.GetInt("pernah");
        Debug.Log(udahtutorial);
        if(udahtutorial == 1)
        {
            SceneManager.LoadScene("ChooseModeScene");
        }
        else
        {
            SceneManager.LoadScene("PrologScene");
        }
        
    }

    public void LoadStoryModeScene()
    {
        SceneManager.LoadScene("LevelSelectScene");
    }

    public void LoadEndlessModeScene()
    {
        SceneManager.LoadScene("EndlessMode");
    }

    public void LoadOptionScene()
    {
        SceneManager.LoadScene("OptionScene");
    }
    
    public void LoadingScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadQuit()
    {
        Application.Quit();
    }
}
