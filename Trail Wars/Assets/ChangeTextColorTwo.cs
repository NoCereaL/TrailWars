using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextColorTwo : MonoBehaviour
{
    public Text text;
    public Text text2;

    public float timeToChange = 0.1f;
    public float timeSinceChange = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Awake()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceChange += Time.deltaTime;

        if (text != null && timeSinceChange >= timeToChange)
        {

            Color newColor = new Color(
                Random.value,
                Random.value,
                Random.value
                );

            text.color = newColor;
            text2.color = newColor;
            timeSinceChange = 0f;
        }
    }
}
