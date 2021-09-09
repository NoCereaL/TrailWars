using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGate : MonoBehaviour
{
    private GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        obstacle = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            obstacle.GetComponent<BoxCollider2D>().isTrigger = true;
        }
        else
        {
            obstacle.GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }
}
