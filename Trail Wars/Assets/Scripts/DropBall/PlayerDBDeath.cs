using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDBDeath : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    public Vector3 spawnPoint;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "obstacle")
        {
            rb.velocity = new Vector2(0, 0);
            player.transform.position = spawnPoint;
        }
    }
}
