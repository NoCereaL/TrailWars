using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public AudioSource buttonClick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenPauseMenu()
    {
        pauseMenu.SetActive(true);
        buttonClick.Play();
        Time.timeScale = 0;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        buttonClick.Play();
        Time.timeScale = 1;
    }

    public void LevelSelect()
    {
        buttonClick.Play();
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        buttonClick.Play();
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        buttonClick.Play();
        Application.Quit();
    }

    public void DropBall()
    {
        buttonClick.Play();
        Time.timeScale = 1;
        SceneManager.LoadScene("DBLevel Selector");
    }

    public void ColorShift()
    {
        buttonClick.Play();
        Time.timeScale = 1;
        SceneManager.LoadScene("CSLevel Selector");
    }
}
