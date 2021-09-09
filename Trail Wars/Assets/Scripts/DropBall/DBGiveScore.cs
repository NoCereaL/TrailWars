using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBGiveScore : MonoBehaviour
{
    public AudioSource success;
    public AudioSource success1;
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
            if (DBEndlessScore.DBScore % 50 == 0 && DBEndlessScore.DBScore >= 50)
            {
                success.Play();
            }
            if (DBEndlessScore.DBScore % 10 == 0 && DBEndlessScore.DBScore >= 10)
            {
                success1.Play();
            }
        }
    }
}
