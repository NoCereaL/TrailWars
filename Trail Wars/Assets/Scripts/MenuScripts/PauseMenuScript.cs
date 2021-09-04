using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class PauseMenuScript : MonoBehaviour, IUnityAdsListener
{
    public GameObject pauseMenu;
    public AudioSource buttonClick;

    public GameObject player;
    public string levelName;
    private NextLevel next;

    public GameObject skipLevelCanvas;
    // Start is called before the first frame update
    void Start()
    {
        next = player.GetComponent<NextLevel>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.name == "CSPlayer")
        {
            levelName = player.GetComponent<CSNextLevel>().level;
        }
        if (player.name == "DBPlayer")
        {
            levelName = player.GetComponent<DBNextLevel>().level;
        }
        else
        {
            levelName = next.level;
        }
    }

    public void OpenPauseMenu()
    {
        pauseMenu.SetActive(true);
        buttonClick.Play();
        //Time.timeScale = 0;
        player.GetComponent<Rigidbody2D>().isKinematic = true;
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        buttonClick.Play();
        //Time.timeScale = 1;
        player.GetComponent<Rigidbody2D>().isKinematic = false;
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }

    public void LevelSelect()
    {
        buttonClick.Play();
        Time.timeScale = 1;
        ABEndlessScore.ABScore = 0;
        CSEndlessScore.CSScore = 0;
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        buttonClick.Play();
        Time.timeScale = 1;
        ABEndlessScore.ABScore = 0;
        CSEndlessScore.CSScore = 0;
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        buttonClick.Play();
        Application.Quit();
    }

    public void ToNextLevel()
    {
        PlayerPrefs.SetInt(levelName, 1);
        ABEndlessScore.ABScore = 0;
        CSEndlessScore.CSScore = 0;
        SceneManager.LoadScene(levelName);
    }

    public void SkipLevel()
    {
        if (Application.platform == RuntimePlatform.OSXEditor)
        {
            if (Advertisement.IsReady("Rewarded_iOS"))
            {
                Advertisement.Show("Rewarded_iOS");
            }
        }
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            if (Advertisement.IsReady("Rewarded_iOS"))
            {
                Advertisement.Show("Rewarded_iOS");
            }
        }
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Advertisement.IsReady("Rewarded_Android"))
            {
                Advertisement.Show("Rewarded_Android");
            }
        }
        OnUnityAdsDidFinish("Rewarded_iOS", ShowResult.Finished);

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

    public void OnUnityAdsReady(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidError(string message)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished)
        {
            pauseMenu.SetActive(false);
            skipLevelCanvas.SetActive(true);
        }
    }
}
