using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CSEndlessScore : MonoBehaviour
{
    public static int CSScore;
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
        score.text = CSScore + "";
    }
}
