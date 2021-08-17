using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class PlayerAdManager : MonoBehaviour
{
    public GameObject player;
    public int showAdsAfter;
    public int deathCounter;
    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "obstacle")
        {
            if(deathCounter >= showAdsAfter)
            {
         
                if (Application.platform == RuntimePlatform.OSXEditor)
                {
                    if (Advertisement.IsReady("Interstitial_iOS"))
                    {
                        Advertisement.Show("Interstitial_iOS");
                    }
                }
                if (Application.platform == RuntimePlatform.IPhonePlayer)
                {
                    if (Advertisement.IsReady("Interstitial_iOS"))
                    {
                        Advertisement.Show("Interstitial_iOS");
                    }
                }
                if (Application.platform == RuntimePlatform.Android)
                {
                    if (Advertisement.IsReady("Interstitial_Android"))
                    {
                        Advertisement.Show("Interstitial_Android");
                    }
                }

                deathCounter = 0;
            }
            deathCounter++;
        }
    }

}
