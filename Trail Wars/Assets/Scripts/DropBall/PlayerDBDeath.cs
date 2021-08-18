using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDBDeath : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    public Vector3 spawnPoint;
    public CameraShake cameraShake;
 
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = new Vector3(player.transform.position.x, player.transform.position.y + 5, player.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "obstacle")
        {
            StartCoroutine(cameraShake.Shake(.1f, .4f));
            rb.velocity = new Vector2(0, 0);
            player.transform.position = spawnPoint;
        }
    }
}
