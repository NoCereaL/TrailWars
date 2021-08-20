using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class PlayerCSDeath : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    public Vector3 spawnPoint;
    public ParticleSystem particleSystem;
    public GameObject particleController;
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
        if (collision.collider.tag == "obstacle")
        {
            CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
            Vibration.VibratePop();
            particleController.transform.position = transform.position;
            particleSystem.Play();
            rb.velocity = new Vector2(0, 0);
            player.transform.position = spawnPoint;
        }
    }
}
