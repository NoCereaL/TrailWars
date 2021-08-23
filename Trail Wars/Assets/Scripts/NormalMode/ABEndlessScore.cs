using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ABEndlessScore : MonoBehaviour
{
    public static int ABScore;
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
        score.text = ABScore +"";
        highScore.text = "HighScore: "+ PlayerPrefs.GetInt("ABHighScore");

    }

    public void SetHighScore()
    {
        if (ABScore > PlayerPrefs.GetInt("ABHighScore"))
        {
            PlayerPrefs.SetInt("ABHighScore", ABScore);
        }
    }
}
