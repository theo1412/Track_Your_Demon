using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject PauseMenuUI;
    public bool isPaused;
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
        MenuState();
    }

    void MenuState()
    {
        if (isPaused)
        {
            PauseMenuUI.SetActive(true);
        }
        else
        {
            PauseMenuUI.SetActive(false);
        }
    }

    public void Resume()
    {
        isPaused = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
