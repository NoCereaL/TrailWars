using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSGiveScore : MonoBehaviour
{
    private void Start()
    {
        Vibration.Init();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            CSEndlessScore.CSScore++;
            Vibration.VibratePeek();
        }
    }
}
