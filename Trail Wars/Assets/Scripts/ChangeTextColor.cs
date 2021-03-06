using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextColor : MonoBehaviour
{
    public Text spriteRenderer;

    public float timeToChange = 0.1f;
    public float timeSinceChange = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        spriteRenderer = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceChange += Time.deltaTime;

        if (spriteRenderer != null && timeSinceChange >= timeToChange)
        {

            Color newColor = new Color(
                Random.value,
                Random.value,
                Random.value
                );

            spriteRenderer.color = newColor;
            timeSinceChange = 0f;
        }
    }
}
