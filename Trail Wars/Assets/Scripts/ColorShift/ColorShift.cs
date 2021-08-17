using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorShift : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public float timeToChange = 0.1f;
    public float timeSinceChange = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceChange += Time.deltaTime;

        Color[] colors = { Color.red, Color.green, Color.blue};

        if (spriteRenderer != null && timeSinceChange >= timeToChange)
        {

            Color newColor = colors[(int)Random.Range(0, 3)];

            spriteRenderer.color = newColor;
            timeSinceChange = 0f;
        }
    }
}

