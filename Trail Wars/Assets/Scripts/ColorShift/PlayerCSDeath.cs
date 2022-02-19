using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
using UnityEngine.UI;

public class PlayerCSDeath : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    private Vector3 spawnPoint;
    private ParticleSystem particleSystem;
    private GameObject particleController;
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
            if (PlayerPrefs.GetInt("Vibration") == 1) { Vibration.VibratePop(); }
            particleController.transform.position = transform.position;
            particleSystem.Play();
            rb.velocity = new Vector2(0, 0);
            rb.isKinematic = true;
            //CSEndlessScore.CSScore = 0;
            //Award Diamond
            int awardedDiamond = CSEndlessScore.CSScore / 3;
            GlobalCurrency.AddCurrency(awardedDiamond);
            player.transform.position = spawnPoint;
            deathSound.Play();

            //XP Rewards
            if (CSEndlessScore.CSScore != 0)
            {
                int awardedXP = CSEndlessScore.CSScore / 2;
                GlobalXP.AddXP(awardedXP);
                GlobalXP.AddToTotalXP(awardedXP);
                xpText.text = "+" + awardedXP + "XP";
            }

            //TinySauce.OnGameFinished(true, CSEndlessScore.CSScore);

            //Play Again
            camera.transform.SetParent(particalController.transform);
            playAgainCanvas.SetActive(true);
            score.text = CSEndlessScore.CSScore + "";
            diamond.text = "+" + awardedDiamond;
            player.GetComponent<PlayerMovement>().enabled = false;   
        }
    }
}
