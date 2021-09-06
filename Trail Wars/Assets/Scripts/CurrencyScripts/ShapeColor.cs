using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShapeColor : MonoBehaviour
{
    private Image item;
    private Color32 color;
    // Start is called before the first frame update
    void Start()
    {
        item = this.gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        float R = PlayerPrefs.GetFloat("R");
        float G = PlayerPrefs.GetFloat("G");
        float B = PlayerPrefs.GetFloat("B");
        color = new Color32((byte)R, (byte)G, (byte)B, 255);
        item.color = color;
    }
}
