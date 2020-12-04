using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame()

    {

        SceneManager.LoadScene("escaperoom1");
    }
    public void playGame2()

    {

        SceneManager.LoadScene("Options");
    }
    public void quitGame()

    {

        Application.Quit();
    }
    public void mainmenu()

    {

        SceneManager.LoadScene("mainmenu");
    }
}

