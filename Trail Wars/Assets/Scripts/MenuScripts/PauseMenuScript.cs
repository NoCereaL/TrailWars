using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using UnityEngine.Advertisements;
using Yodo1.MAS;

public class PauseMenuScript : MonoBehaviour //IUnityAdsListener
{
    public GameObject pauseMenu;
    public AudioSource buttonClick;

    public GameObject player;
    public string levelName;
    private NextLevel next;

    public GameObject skipLevelCanvas;
    public static bool pauseOpen;
    bool isLoaded;
    // Start is called before the first frame update
    void Start()
    {
        next = player.GetComponent<NextLevel>();
        InitializeRewardedAds();
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
        isLoaded = Yodo1U3dMas.IsRewardedAdLoaded();
    }

    public void OpenPauseMenu()
    {
        pauseMenu.SetActive(true);
        buttonClick.Play();
        //Time.timeScale = 0;
        player.GetComponent<Rigidbody2D>().isKinematic = true;
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        pauseOpen = true;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        buttonClick.Play();
        //Time.timeScale = 1;
        player.GetComponent<Rigidbody2D>().isKinematic = false;
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        pauseOpen = false;
    }

    public void LevelSelect()
    {
        pauseOpen = false;
        buttonClick.Play();
        Time.timeScale = 1;
        ABEndlessScore.ABScore = 0;
        CSEndlessScore.CSScore = 0;
        DBEndlessScore.DBScore = 0;
        CheckContinues.numOfContinuesUsed = 0;
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        pauseOpen = false;
        buttonClick.Play();
        Time.timeScale = 1;
        ABEndlessScore.ABScore = 0;
        CSEndlessScore.CSScore = 0;
        DBEndlessScore.DBScore = 0;
        CheckContinues.numOfContinuesUsed = 0;
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        buttonClick.Play();
        Application.Quit();
    }

    public void ToNextLevel()
    {
        pauseOpen = false;
        PlayerPrefs.SetInt(levelName, 1);
        ABEndlessScore.ABScore = 0;
        CSEndlessScore.CSScore = 0;
        DBEndlessScore.DBScore = 0;
        CheckContinues.numOfContinuesUsed = 0;
        SceneManager.LoadScene(levelName);
    }

    public void SkipLevel()
    {
        pauseOpen = false;
        skipLevelCanvas.SetActive(true);
        pauseMenu.SetActive(false);
        if (Application.platform == RuntimePlatform.OSXEditor)
        {
            //Unity Ads disabled
            /*
            if (Advertisement.IsReady("Rewarded_iOS"))
            {
                Advertisement.Show("Rewarded_iOS");
            }*/
            if (Yodo1U3dMas.IsRewardedAdLoaded()) Yodo1U3dMas.ShowRewardedAd();
            //Yodo1U3dMasCallback.Rewarded.OnAdClosedEvent += OnRewardedAdClosedEvent;
        }
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //Unity Ads disabled
            /*
            if (Advertisement.IsReady("Rewarded_iOS"))
            {
                Advertisement.Show("Rewarded_iOS");
            }*/
            if (Yodo1U3dMas.IsRewardedAdLoaded()) Yodo1U3dMas.ShowRewardedAd();
        }
        if (Application.platform == RuntimePlatform.Android)
        {
            //Unity Ads disabled
            /*
            if (Advertisement.IsReady("Rewarded_Android"))
            {
                Advertisement.Show("Rewarded_Android");
            }*/
            if (Yodo1U3dMas.IsRewardedAdLoaded()) Yodo1U3dMas.ShowRewardedAd();
        }
        //OnUnityAdsDidFinish("Rewarded_iOS", ShowResult.Finished);
        
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
    //Unity Ads
    /*
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
    }*/

    private void InitializeRewardedAds()
    {
        // Add Events
        Yodo1U3dMasCallback.Rewarded.OnAdOpenedEvent += OnRewardedAdOpenedEvent;
        Yodo1U3dMasCallback.Rewarded.OnAdClosedEvent += OnRewardedAdClosedEvent;
        Yodo1U3dMasCallback.Rewarded.OnAdReceivedRewardEvent += OnAdReceivedRewardEvent;
        Yodo1U3dMasCallback.Rewarded.OnAdErrorEvent += OnRewardedAdErorEvent;
    }

    private void OnRewardedAdOpenedEvent()
    {
        Debug.Log("[Yodo1 Mas] Rewarded ad opened");
    }

    private void OnRewardedAdClosedEvent()
    {
        Debug.Log("[Yodo1 Mas] Rewarded ad closed");
    }

    private void OnAdReceivedRewardEvent()
    {
        Debug.Log("[Yodo1 Mas] Rewarded ad received reward");
    }

    private void OnRewardedAdErorEvent(Yodo1U3dAdError adError)
    {
        Debug.Log("[Yodo1 Mas] Rewarded ad error - " + adError.ToString());
    }
}
