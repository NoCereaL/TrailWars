using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class PlayerAdManager : MonoBehaviour
{
    public GameObject player;
    public Vector3 spawnPoint;
    public int showAdsAfter;
    public int deathCounter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "obstacle")
        {
            if(deathCounter >= showAdsAfter)
            {
                if (Advertisement.IsReady("Rewarded_iOS"))
                {
                    Advertisement.Show("Rewarded_iOS");
                }
                deathCounter = 0;
            }
            deathCounter++;
        }
    }

}
