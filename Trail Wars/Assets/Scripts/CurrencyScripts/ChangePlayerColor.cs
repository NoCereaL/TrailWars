using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerColor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public float R;
    public float G;
    public float B;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        SetPlayerColor();
    }

    public void SetPlayerColor()
    {
        R = PlayerPrefs.GetFloat("R");
        G = PlayerPrefs.GetFloat("G");
        B = PlayerPrefs.GetFloat("B");
        spriteRenderer.color = new Color32((byte)R, (byte)G, (byte)B, 255);
    }
}
