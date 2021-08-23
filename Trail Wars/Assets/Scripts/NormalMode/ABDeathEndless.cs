using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class ABDeathEndless : MonoBehaviour
{
    public GameObject player;
    public Vector3 spawnPoint;
    public ParticleSystem particleSystem;
    public GameObject particleController;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        Vibration.Init();
        particleSystem = GameObject.Find("ParticleController").GetComponent<ParticleSystem>();
        particleController = GameObject.Find("ParticleController");
        rb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        DieToFall();
    }

    public void DieToFall()
    {
        if (rb.velocity.y < -15)
        {
            CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
            Vibration.VibratePop();
            //particleSystem.Play();
            particleController.transform.position = transform.position;
            particleSystem.Play();
            rb.velocity = Vector2.zero;
            ABEndlessScore.ABScore = 0;
            player.transform.position = spawnPoint;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "obstacle")
        {
            CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
            Vibration.VibratePop();
            //particleSystem.Play();
            particleController.transform.position = transform.position;
            particleSystem.Play();
            rb.velocity = Vector2.zero;
            ABEndlessScore.ABScore = 0;
            player.transform.position = spawnPoint;
        }
    }
}
