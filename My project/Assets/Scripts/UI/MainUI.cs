using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    [SerializeField] private GameObject MenuScreen;

    private void Start()
    {
        MenuScreen.SetActive(false);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Continue()
    {
        MenuScreen.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void MenuButtonClick()
    {
        MenuScreen.SetActive(true);
        Time.timeScale = 0.0f;
    }
}
