using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Scene_CharacterSelection");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
