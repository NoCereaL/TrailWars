using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DBEndlessScore : MonoBehaviour
{
    public static int DBScore;
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
        score.text = DBScore + "";
        highScore.text = "HighScore: " + PlayerPrefs.GetInt("DBHighScore");
    }

    public void SetHighScore()
    {
        if (DBScore > PlayerPrefs.GetInt("DBHighScore"))
        {
            PlayerPrefs.SetInt("DBHighScore", DBScore);
        }
    }
}
