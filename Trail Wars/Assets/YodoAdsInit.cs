using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yodo1.MAS;

public class YodoAdsInit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Yodo1U3dMas.SetInitializeDelegate((bool success, Yodo1U3dAdError error) => { });
        Yodo1U3dMas.InitializeSdk();

        this.gameObject.GetComponent<YodoAdsInit>().enabled = false;
    }
}
