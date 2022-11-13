using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button: MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Main");
    }
    public void BackButton()
    {
        SceneManager.LoadScene("Start");
    }
    public void QuitButton()
    {
        Application.Quit();
    }

    public void MainButton()
    {
        SceneManager.LoadScene("Start");
    }
}

