using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
using UnityEngine.UI;
using CloudOnce;

public class ABGiveScore : MonoBehaviour
{
    private Transform player;
    private ParticleSystem particleSystem;
    private GameObject particleController;
    private Rigidbody2D rb;
    private Vector3 spawnPoint;
    public AudioSource deathSound;

    //Play Again Canvas
    public Text score;
    public Text diamond;
    public Text xpText;
    public GameObject playAgainCanvas;
    public GameObject camera;
    public GameObject particalController;

    public AudioSource success;
    public AudioSource success1;

    public void Start()
    {
        Cloud.Initialize();
    }

    private void Awake()
    {
        player = GameObject.Find("ABPlayerEndless").GetComponent<Transform>();
        spawnPoint = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        Vibration.Init();
        particleSystem = GameObject.Find("ParticleController").GetComponent<ParticleSystem>();
        particleController = GameObject.Find("ParticleController");
        rb = player.GetComponent<Rigidbody2D>();
    }

    public void SubmitTheScore()
    {
        Leaderboards.AscendBallHighScore.SubmitScore(ABEndlessScore.ABScore);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && player.position.y <= this.gameObject.transform.position.y)
        {
            ABEndlessScore.ABScore++;
            if (PlayerPrefs.GetInt("Vibration") == 1) { Vibration.VibratePeek(); }
            if (ABEndlessScore.ABScore % 50 == 0 && ABEndlessScore.ABScore >= 50)
            {
                success.Play();
            }
            if (ABEndlessScore.ABScore % 10 == 0 && ABEndlessScore.ABScore >= 10)
            {
                success1.Play();
            }
        }
        if (collision.tag == "Player" && player.position.y >= this.gameObject.transform.position.y)
        {
            CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
            if (PlayerPrefs.GetInt("Vibration") == 1) { Vibration.VibratePop(); }
            //particleSystem.Play();
            particleController.transform.position = transform.position;
            particleSystem.Play();
            rb.velocity = Vector2.zero;
            //ABEndlessScore.ABScore = 0;
            player.transform.position = spawnPoint;
            deathSound.Play();

            //Submit Score to Leaderboard
            SubmitTheScore();

            //Play Again
            camera.transform.SetParent(particalController.transform);
            playAgainCanvas.SetActive(true);
            score.text = ABEndlessScore.ABScore + "";
            player.GetComponent<PlayerMovement>().enabled = false;
            //StartCoroutine(PauseGame());

            //Currency Rewards
            int awardedDiamond = ABEndlessScore.ABScore / 3;
            GlobalCurrency.AddCurrency(awardedDiamond);
            diamond.text = "+" + awardedDiamond;

            //XP Rewards
            int awardedXP = ABEndlessScore.ABScore / 2;
            GlobalXP.AddXP(awardedXP);
            GlobalXP.AddToTotalXP(awardedXP);
            xpText.text = "+" + awardedXP + "XP";
        }
    }
}
