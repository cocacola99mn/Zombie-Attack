using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject OptionPanel;
    public void Play()
    {
        SceneManager.LoadScene("Gameplay");
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void OpenOptions()
    {
        OptionPanel.SetActive(true);
    }

    public void CloseOptions()
    {
        OptionPanel.SetActive(false);
    }
}
