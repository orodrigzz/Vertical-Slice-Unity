using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public GameObject UI;

    void Start()
    {
        UI.SetActive(false);
    }

    public void Fired()
    {
        SceneManager.LoadScene("Fired");
    }

    public void Game1()
    {
        SceneManager.LoadScene("Game1");
    }

    public void Game2()
    {
        SceneManager.LoadScene("Game2");
    }

    public void Game3()
    {
        SceneManager.LoadScene("Game3");
    }

    public void Game4()
    {
        SceneManager.LoadScene("Game4");
    }

    public void Game5()
    {
        SceneManager.LoadScene("Game5");
    }

    public void Game6()
    {
        SceneManager.LoadScene("Game6");
    }

    public void Game7()
    {
        SceneManager.LoadScene("Game7");
    }
}
