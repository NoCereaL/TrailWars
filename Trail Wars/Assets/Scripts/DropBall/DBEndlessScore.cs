using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DBEndlessScore : MonoBehaviour
{
    public static int DBScore;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GiveScore();
    }

    public void GiveScore()
    {
        score.text = DBScore + "";
    }
}
