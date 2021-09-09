using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBAudioDriver : MonoBehaviour
{
    public AudioSource success1;
    public AudioSource success2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DBEndlessScore.DBScore % 50 == 0 && DBEndlessScore.DBScore >= 50)
        {
            success2.Play();
        }
        if (DBEndlessScore.DBScore % 10 == 0 && DBEndlessScore.DBScore >= 10)
        {
            success1.Play();
        }
    }
}
