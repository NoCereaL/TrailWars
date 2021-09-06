using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImageColor : MonoBehaviour
{
    public Image image;

    public float timeToChange = 0.1f;
    public float timeSinceChange = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Awake()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceChange += Time.deltaTime;

        if (image != null && timeSinceChange >= timeToChange)
        {

            Color newColor = new Color(
                Random.value,
                Random.value,
                Random.value
                );

            image.color = newColor;
            timeSinceChange = 0f;
        }
    }
}
