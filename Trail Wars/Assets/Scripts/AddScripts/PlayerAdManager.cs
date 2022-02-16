using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
using Yodo1.MAS;

public class PlayerAdManager : MonoBehaviour
{
    public GameObject player;
    public int showAdsAfter;
    public int deathCounter;
    [SerializeField] bool isLoaded;
    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
    }

    private void Update()
    {
        isLoaded = Yodo1U3dMas.IsInterstitialAdLoaded();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "obstacle")
        {
            if(deathCounter > showAdsAfter)
            {
                deathCounter = 0;
                if (Application.platform == RuntimePlatform.OSXEditor)
                {
                    //Unity Ads Disabled
                    /*
                    if (Advertisement.IsReady("Interstitial_iOS"))
                    {
                        Advertisement.Show("Interstitial_iOS");
                    }*/
                    Yodo1U3dMas.ShowInterstitialAd("Interstitial_iOS");
                    deathCounter = 0;
                }
                if (Application.platform == RuntimePlatform.IPhonePlayer)
                {
                    //Unity Ads Disabled
                    /*
                    if (Advertisement.IsReady("Interstitial_iOS"))
                    {
                        Advertisement.Show("Interstitial_iOS");
                    }*/
                    Yodo1U3dMas.ShowInterstitialAd("Interstitial_iOS");
                    deathCounter = 0;
                }
                if (Application.platform == RuntimePlatform.Android)
                {
                    //Unity Ads Disabled
                    /*
                    if (Advertisement.IsReady("Interstitial_Android"))
                    {
                        Advertisement.Show("Interstitial_Android");
                    }*/
                    Yodo1U3dMas.ShowInterstitialAd("Interstitial_Android");
                    deathCounter = 0;
                }

            }
            deathCounter += 1;
        }
    }

}
