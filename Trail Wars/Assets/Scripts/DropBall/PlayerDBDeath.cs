using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
using UnityEngine.UI;

public class PlayerDBDeath : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    private Vector3 spawnPoint;
    private ParticleSystem particleSystem;
    private GameObject particleController;

    //Play Again Canvas
    public Text score;
    public GameObject playAgainCanvas;
    public GameObject camera;
    public GameObject particalController;
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
        if(collision.collider.tag == "obstacle")
        {
            CameraShaker.Instance.ShakeOnce(4f,4f,.1f,1f);
            Vibration.VibratePop();
            particleController.transform.position = transform.position;
            particleSystem.Play();
            rb.velocity = new Vector2(0, 0);
            rb.isKinematic = true;
            player.transform.position = spawnPoint;

            //Play Again
            camera.transform.SetParent(particalController.transform);
            playAgainCanvas.SetActive(true);
            score.text = CSEndlessScore.CSScore + "";
            player.GetComponent<PlayerMovement>().enabled = false;
        }
    }
}
