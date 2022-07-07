using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void MainStart()
    {
        PickItem.score = 0;
        SceneManager.LoadScene("SceneGame");
    }
    public void ExitGame()
    {
        Application.Quit();    
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void PlayAgain()
    {
        PickItem.score = 0;
        SceneManager.LoadScene("SceneGame");
    }

}
