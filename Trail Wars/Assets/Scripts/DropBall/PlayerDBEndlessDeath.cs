using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CloudOnce;

public class PlayerDBEndlessDeath : MonoBehaviour
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
            Leaderboards.DropBallHighScore.SubmitScore(DBEndlessScore.DBScore);
        }
    }
}
