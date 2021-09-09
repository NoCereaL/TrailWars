using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBGiveScore : MonoBehaviour
{
    private void Start()
    {
        Vibration.Init();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            DBEndlessScore.DBScore++;
            Vibration.VibratePeek();
        }
    }
}
