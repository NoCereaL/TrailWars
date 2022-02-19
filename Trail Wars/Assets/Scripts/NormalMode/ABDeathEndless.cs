using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
using UnityEngine.UI;
using CloudOnce;

public class ABDeathEndless : MonoBehaviour
{
    public GameObject player;
    public Vector3 spawnPoint;
    public ParticleSystem particleSystem;
    public GameObject particleController;
    public Rigidbody2D rb;
    public AudioSource deathSound;

    //Play Again Canvas
    public Text score;
    public Text diamond;
    public Text xpText;
    public GameObject playAgainCanvas;
    public GameObject camera;
    public GameObject particalController;
    // Start is called before the first frame update
    void Start()
    {
        Cloud.Initialize();
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

    public void SubmitTheScore()
    {
        Leaderboards.AscendBallHighScore.SubmitScore(ABEndlessScore.ABScore);
    }

    public void DieToFall()
    {
        if (rb.velocity.y < -15)
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
            //TinySauce.OnGameFinished(true,ABEndlessScore.ABScore);

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "obstacle")
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
            //TinySauce.OnGameFinished(true, ABEndlessScore.ABScore);

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "obstacle")
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
            //TinySauce.OnGameFinished(true, ABEndlessScore.ABScore);

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

    IEnumerator PauseGame()
    {
        yield return new WaitForSeconds(2);
        Time.timeScale = 0;
    }
}
