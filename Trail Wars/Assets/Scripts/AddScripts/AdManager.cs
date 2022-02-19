using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{
    [SerializeField] string _androidGameID;
    [SerializeField] string _iOSGameID;
    [SerializeField] bool _testMode;

    private string _gameId;

    void Awake()
    {
        //InitializeAds();
    }

    void Start()
    {
        //Advertisement.Initialize("4268228", true);
        InitializeAds();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Advertisement.IsReady("Rewarded_iOS"))
            {
                Advertisement.Show("Rewarded_iOS");
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (Advertisement.IsReady("Interstitial_iOS"))
            {
                Advertisement.Show("Interstitial_iOS");
            }
        }*/
    }

    public void InitializeAds()
    {
        if(Application.platform == RuntimePlatform.OSXEditor)
        {
            _gameId = _iOSGameID;
        }
        if(Application.platform == RuntimePlatform.IPhonePlayer)
        {
            _gameId = _iOSGameID;
        }
        if(Application.platform == RuntimePlatform.Android)
        {
            _gameId = _androidGameID;
        }
        //_gameId = (Application.platform == RuntimePlatform.IPhonePlayer) ? _androidGameID : _iOSGameID;

        //Advertisement.Initialize(_gameId, _testMode);

        Debug.Log(_gameId);

    }
}
