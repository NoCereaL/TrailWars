using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CloudOnce;

public class PlayerCSEndlessDeath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cloud.Initialize();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "obstacle")
        {
            Leaderboards.ColorShiftHighScore.SubmitScore(CSEndlessScore.CSScore);
        }
    }
}
