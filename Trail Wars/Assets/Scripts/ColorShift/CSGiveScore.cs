using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSGiveScore : MonoBehaviour
{
    public AudioSource success;
    public AudioSource success1;
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
            if (CSEndlessScore.CSScore % 50 == 0 && CSEndlessScore.CSScore >= 50)
            {
                success.Play();
            }
            if (CSEndlessScore.CSScore % 10 == 0 && CSEndlessScore.CSScore >= 10)
            {
                success1.Play();
            }
        }
    }
}
