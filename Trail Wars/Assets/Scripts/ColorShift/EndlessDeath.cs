using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class EndlessDeath : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    public Vector3 spawnPoint;
    public ParticleSystem particleSystem;
    public GameObject particleController;
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = new Vector3(player.transform.position.x, player.transform.position.y + 3, player.transform.position.z);
        Vibration.Init();
        particleSystem = GameObject.Find("ParticleController").GetComponent<ParticleSystem>();
        particleController = GameObject.Find("ParticleController");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            //Finish Method for re-enabling Endless Color Shift Script after player dies.
        }
    }
}
