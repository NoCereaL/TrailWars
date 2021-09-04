using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public AudioSource buttonClick;
    private GameObject menu;
    public GameObject credits;
    public GameObject storePage;
    // Start is called before the first frame update
    void Start()
    {
        menu = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        buttonClick.Play();
        SceneManager.LoadScene(1);
    }

    public void BackButton()
    {
        buttonClick.Play();
        SceneManager.LoadScene("ModeSelect");
    }

    public void BackToMain()
    {
        buttonClick.Play();
        SceneManager.LoadScene("Main Menu");
    }

    public void Credits()
    {
        menu.SetActive(false);
        credits.SetActive(true);
        storePage.SetActive(false);
        buttonClick.Play();
    }

    public void CloseAll()
    {
        menu.SetActive(true);
        credits.SetActive(false);
        storePage.SetActive(false);
        buttonClick.Play();
    }

    public void StorePage()
    {
        menu.SetActive(false);
        credits.SetActive(false);
        storePage.SetActive(true);
        buttonClick.Play();
    }

    public void Quit()
    {
        buttonClick.Play();
        Application.Quit();
    }

    public void AccendBall() {
        buttonClick.Play();
        SceneManager.LoadScene(2);
    }

    public void DropBall()
    {
        buttonClick.Play();
        SceneManager.LoadScene(3);
    }

    public void ColorShift()
    {
        buttonClick.Play();
        SceneManager.LoadScene(4);
    }

    //Ascend Ball Levels

    public void ABEndless()
    {
        SceneManager.LoadScene("ABEndless");
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void Level4()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void Level5()
    {
        SceneManager.LoadScene("Level 5");
    }

    //Drop Ball Levels

    public void DBLevel1()
    {
        SceneManager.LoadScene("DB Level 1");
    }

    public void DBLevel2()
    {
        SceneManager.LoadScene("DB Level 2");
    }

    public void DBLevel3()
    {
        SceneManager.LoadScene("DB Level 3");
    }

    public void DBLevel4()
    {
        SceneManager.LoadScene("DB Level 4");
    }

    public void DBLevel5()
    {
        SceneManager.LoadScene("DB Level 5");
    }

    //Color Shift Levels

    public void CSEndless()
    {
        SceneManager.LoadScene("CS Endless");
    }

    public void CSLevel1()
    {
        SceneManager.LoadScene("CS Level 1");
    }

    public void CSLevel2()
    {
        SceneManager.LoadScene("CS Level 2");
    }

    public void CSLevel3()
    {
        SceneManager.LoadScene("CS Level 3");
    }

    public void CSLevel4()
    {
        SceneManager.LoadScene("CS Level 4");
    }

    public void CSLevel5()
    {
        SceneManager.LoadScene("CS Level 5");
    }
}
