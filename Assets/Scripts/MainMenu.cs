using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject startMenu;

    public void StartGame() 
    {
        mainMenu.SetActive(false);
        startMenu.SetActive(true);
    }

    public void BackMain()
    {
        startMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void StartStory()
    {
        SceneManager.LoadScene(1);
    }

    public void StartArcade()
    {
        SceneManager.LoadScene(2);
    }
}
