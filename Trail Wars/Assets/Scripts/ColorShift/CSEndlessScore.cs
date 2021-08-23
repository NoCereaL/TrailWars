using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CSEndlessScore : MonoBehaviour
{
    public static int CSScore;
    public Text score;
    public Text highScore;


    // Update is called once per frame
    void Update()
    {
        SetHighScore();
        GiveScore();
    }

    public void GiveScore()
    {
        score.text = CSScore + "";
        highScore.text = "HighScore: " + PlayerPrefs.GetInt("CSHighScore");
    }

    public void SetHighScore()
    {
        if (CSScore > PlayerPrefs.GetInt("CSHighScore"))
        {
            PlayerPrefs.SetInt("CSHighScore", CSScore);
        }
    }
}
