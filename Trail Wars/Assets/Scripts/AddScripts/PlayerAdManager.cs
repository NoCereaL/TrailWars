using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Advertisements;
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
        InitializeInterstitialAds();
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
                    if(Yodo1U3dMas.IsInterstitialAdLoaded()) Yodo1U3dMas.ShowInterstitialAd();
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
                    if (Yodo1U3dMas.IsInterstitialAdLoaded()) Yodo1U3dMas.ShowInterstitialAd();
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
                    if (Yodo1U3dMas.IsInterstitialAdLoaded()) Yodo1U3dMas.ShowInterstitialAd();
                    deathCounter = 0;
                }

            }
            deathCounter += 1;
        }
    }

    private void InitializeInterstitialAds()
    {
        Yodo1U3dMasCallback.Interstitial.OnAdOpenedEvent +=
        OnInterstitialAdOpenedEvent;
        Yodo1U3dMasCallback.Interstitial.OnAdClosedEvent +=
        OnInterstitialAdClosedEvent;
        Yodo1U3dMasCallback.Interstitial.OnAdErrorEvent +=
        OnInterstitialAdErorEvent;
    }

    private void OnInterstitialAdOpenedEvent()
    {
        Debug.Log("[Yodo1 Mas] Interstitial ad opened");
    }

    private void OnInterstitialAdClosedEvent()
    {
        Debug.Log("[Yodo1 Mas] Interstitial ad closed");
    }

    private void OnInterstitialAdErorEvent(Yodo1U3dAdError adError)
    {
        Debug.Log("[Yodo1 Mas] Interstitial ad error - " + adError.ToString());
    }

}
