using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenLight : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public float timeToChange = 0.1f;
    public float timeSinceChange = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        timeSinceChange += Time.deltaTime;

        if (spriteRenderer != null && timeSinceChange >= timeToChange)
        {
            float rand = Random.value;
            Color newColor = new Color(
                1-rand,
                1-rand,
                1-rand
                );

            spriteRenderer.color = newColor;
            timeSinceChange = 0f;
        }
    }
}
