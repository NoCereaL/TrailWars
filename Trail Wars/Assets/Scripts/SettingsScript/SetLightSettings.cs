using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class SetLightSettings : MonoBehaviour
{
    private Light2D light;
    // Start is called before the first frame update
    void Start()
    {
        light = this.gameObject.GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        light.intensity = PlayerPrefs.GetFloat("Brightness");
    }
}
