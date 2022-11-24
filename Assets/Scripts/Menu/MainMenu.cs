using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void Menu ()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
 
}
