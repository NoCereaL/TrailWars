using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public AudioSource buttonClick;
    public GameObject menu;
    public GameObject credits;
    public GameObject storePage;
    public GameObject storePageShapes;
    public GameObject settingsPage;
    public GameObject statsPage;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("Brightness"))
        {
            PlayerPrefs.SetFloat("Brightness", 0.2f);
        }
        if(Application.platform == RuntimePlatform.IPhonePlayer)
        {
            Application.targetFrameRate = 60;
        }
        if (Application.platform == RuntimePlatform.Android)
        {
            Application.targetFrameRate = 60;
        }
        Vibration.Init();
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
        storePageShapes.SetActive(false);
        settingsPage.SetActive(false);
        statsPage.SetActive(false);
        buttonClick.Play();
    }

    public void CloseAll()
    {
        menu.SetActive(true);
        credits.SetActive(false);
        storePage.SetActive(false);
        storePageShapes.SetActive(false);
        settingsPage.SetActive(false);
        statsPage.SetActive(false);
        buttonClick.Play();
    }

    public void StorePage()
    {
        menu.SetActive(false);
        credits.SetActive(false);
        storePage.SetActive(true);
        storePageShapes.SetActive(false);
        settingsPage.SetActive(false);
        statsPage.SetActive(false);
        buttonClick.Play();
    }

    public void StorePageShapes()
    {
        menu.SetActive(false);
        credits.SetActive(false);
        storePage.SetActive(false);
        storePageShapes.SetActive(true);
        settingsPage.SetActive(false);
        statsPage.SetActive(false);
        buttonClick.Play();
    }

    public void SettingsCanvas()
    {
        menu.SetActive(false);
        credits.SetActive(false);
        storePage.SetActive(false);
        storePageShapes.SetActive(false);
        settingsPage.SetActive(true);
        statsPage.SetActive(false);
        buttonClick.Play();
    }

    public void StatsCanvas()
    {
        menu.SetActive(false);
        credits.SetActive(false);
        storePage.SetActive(false);
        storePageShapes.SetActive(false);
        settingsPage.SetActive(false);
        statsPage.SetActive(true);
        buttonClick.Play();
    }

    public void Quit()
    {
        buttonClick.Play();
        Application.Quit();
    }

    public void AccendBall() {
        buttonClick.Play();
        if (PlayerPrefs.GetInt("Vibration") == 1) { Vibration.VibratePop(); }
        SceneManager.LoadScene(2);
    }

    public void DropBall()
    {
        buttonClick.Play();
        if (PlayerPrefs.GetInt("Vibration") == 1) { Vibration.VibratePop(); }
        SceneManager.LoadScene(3);
    }

    public void ColorShift()
    {
        buttonClick.Play();
        if (PlayerPrefs.GetInt("Vibration") == 1) { Vibration.VibratePop(); }
        SceneManager.LoadScene(4);
    }

    //Ascend Ball Levels

    public void ABEndless()
    {
        //TinySauce.OnGameStarted("ABEndless");
        SceneManager.LoadScene("ABEndless");
        buttonClick.Play();
    }


    //Drop Ball Levels

    public void DBEndless()
    {
        //TinySauce.OnGameStarted("DB Endless");
        SceneManager.LoadScene("DB Endless");
        buttonClick.Play();
    }

    //Color Shift Levels

    public void CSEndless()
    {
        //TinySauce.OnGameStarted("CS Endless Hard");
        SceneManager.LoadScene("CS Endless Hard");
        buttonClick.Play();
    }

}
