using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Yodo1.MAS;

public class PlayAgainScript : MonoBehaviour
{
    public GameObject playAgainCanvas;
    public GameObject cam;
    public GameObject cameraHolder;
    public GameObject player;
    public Rigidbody2D rb;
    public AudioSource audio;
    public GameObject diamondText;
    public GameObject xpText;
    public GameObject continueCanvas;

    public void PlayAgain()
    {
        playAgainCanvas.SetActive(false);
        continueCanvas.SetActive(false);
        diamondText.SetActive(true);
        xpText.SetActive(true);
        Time.timeScale = 1;
        ABEndlessScore.ABScore = 0;
        CSEndlessScore.CSScore = 0;
        DBEndlessScore.DBScore = 0;
        CheckContinues.numOfContinuesUsed = 0;
        xpText.GetComponent<Text>().text = "0";
        cam.transform.SetParent(cameraHolder.transform);
        rb.isKinematic = false;
        if(player.GetComponent<PlayerMovement>() != null)
        {
            player.GetComponent<PlayerMovement>().enabled = true;
        }
        if (player.GetComponent<PlayerCSMovement>() != null)
        {
            player.GetComponent<PlayerCSMovement>().enabled = true;
        }
        if(player.GetComponent<PlayerAdManager>().deathCounter > player.GetComponent<PlayerAdManager>().showAdsAfter)
        {
            //player.GetComponent<PlayerAdManager>().deathCounter = 0;
        }
        audio.Play();
    }

    public void Continue()
    {
        continueCanvas.SetActive(true);
        playAgainCanvas.SetActive(false);
        if (player.GetComponent<PlayerMovement>() != null)
        {
            player.GetComponent<Rigidbody2D>().isKinematic = true;
        }
        if (Application.platform == RuntimePlatform.OSXEditor)
        {
            Yodo1U3dMas.ShowRewardedAd("Rewarded_iOS");
        }
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            Yodo1U3dMas.ShowRewardedAd("Rewarded_iOS");
        }
        if (Application.platform == RuntimePlatform.Android)
        {
            Yodo1U3dMas.ShowRewardedAd("Rewarded_Android");
        }
        audio.Play();
    }

    public void BackToMenu()
    {
        ABEndlessScore.ABScore = 0;
        CSEndlessScore.CSScore = 0;
        DBEndlessScore.DBScore = 0;
        CheckContinues.numOfContinuesUsed = 0;
        SceneManager.LoadScene("Main Menu");
        audio.Play();
    }
}
