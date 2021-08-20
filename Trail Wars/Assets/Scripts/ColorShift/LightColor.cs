using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightColor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Light2D light2D;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        light2D = this.gameObject.GetComponent<Light2D>();
        ChangeLightColor();
    }

    public void ChangeLightColor()
    {
        light2D.color = spriteRenderer.color;
    }
}
