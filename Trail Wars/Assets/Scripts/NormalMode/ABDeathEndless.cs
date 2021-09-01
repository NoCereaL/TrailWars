using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
using UnityEngine.UI;

public class ABDeathEndless : MonoBehaviour
{
    public GameObject player;
    public Vector3 spawnPoint;
    public ParticleSystem particleSystem;
    public GameObject particleController;
    public Rigidbody2D rb;

    //Play Again Canvas
    public Text score;
    public GameObject playAgainCanvas;
    public GameObject camera;
    public GameObject particalController;
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
            //ABEndlessScore.ABScore = 0;
            player.transform.position = spawnPoint;

            //Play Again
            camera.transform.SetParent(particalController.transform);
            playAgainCanvas.SetActive(true);
            score.text = ABEndlessScore.ABScore + "";
            player.GetComponent<PlayerMovement>().enabled = false;
            //StartCoroutine(PauseGame());
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
            //ABEndlessScore.ABScore = 0;
            player.transform.position = spawnPoint;

            //Play Again
            camera.transform.SetParent(particalController.transform);
            playAgainCanvas.SetActive(true);
            score.text = ABEndlessScore.ABScore + "";
            player.GetComponent<PlayerMovement>().enabled = false;
            //StartCoroutine(PauseGame());
        }
    }

    IEnumerator PauseGame()
    {
        yield return new WaitForSeconds(2);
        Time.timeScale = 0;
    }
}