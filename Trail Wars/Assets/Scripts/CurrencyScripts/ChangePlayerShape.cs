using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerShape : MonoBehaviour
{
    public Sprite[] spriteArray;
    public SpriteRenderer spriteRenderer;
    private Sprite sprite;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        /*spriteRenderer.sprite = sprite;
        for (int i = 0; i >= spriteArray.Length; i++)
        {
            if (PlayerPrefs.GetInt("PlayerShape") == i)
            {
                sprite = spriteArray[i];
                spriteRenderer.sprite = sprite;
            }
        }*/

        if (PlayerPrefs.GetInt("PlayerShape") == 0)
        {
            sprite = spriteArray[0];
            spriteRenderer.sprite = sprite;
        }
        if (PlayerPrefs.GetInt("PlayerShape") == 1)
        {
            sprite = spriteArray[1];
            spriteRenderer.sprite = sprite;
        }
        if (PlayerPrefs.GetInt("PlayerShape") == 2)
        {
            sprite = spriteArray[2];
            spriteRenderer.sprite = sprite;
        }
    }
}
