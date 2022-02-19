using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Advertisements;

public class AdBannerScript : MonoBehaviour
{
    [SerializeField] string androidPlacementId;
    [SerializeField] string iOSPlacementId;

    private string placementId;
    void Start()
    {
        if (Application.platform == RuntimePlatform.OSXEditor)
        {
            placementId = iOSPlacementId;
        }
        if (Application.platform == RuntimePlatform.Android)
        {
            placementId = androidPlacementId;
        }
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            placementId = iOSPlacementId;
        }
        //StartCoroutine(ShowBannerWhenReady());
    }

    /*
    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady(placementId))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show(placementId);
        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
    }
    */
}
