using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ABHighScore : MonoBehaviour
{
    private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Best: " +PlayerPrefs.GetInt("ABHighScore");
    }
}
