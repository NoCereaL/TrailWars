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
        if(collision.collider.tag == "obstacle")
        {
            CameraShaker.Instance.ShakeOnce(4f,4f,.1f,1f);
            Vibration.VibratePop();
            particleController.transform.position = transform.position;
            particleSystem.Play();
            rb.velocity = new Vector2(0, 0);
            rb.isKinematic = true;
            //Award Diamond
            int awardedDiamond = DBEndlessScore.DBScore / 3;
            GlobalCurrency.AddCurrency(awardedDiamond);
            player.transform.position = spawnPoint;
            deathSound.Play();

            //XP Rewards
            if(DBEndlessScore.DBScore != 0)
            {
                int awardedXP = DBEndlessScore.DBScore / 2;
                GlobalXP.AddXP(awardedXP);
                GlobalXP.AddToTotalXP(awardedXP);
                xpText.text = "+" + awardedXP + "XP";
            }
            TinySauce.OnGameFinished(true, DBEndlessScore.DBScore);

            //Play Again
            camera.transform.SetParent(particalController.transform);           //Transform Camera position to Particle Controller
            playAgainCanvas.SetActive(true);
            score.text = DBEndlessScore.DBScore + "";
            diamond.text = "+" + awardedDiamond;
            player.GetComponent<PlayerMovement>().enabled = false;     
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "obstacle")
        {
            CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
            Vibration.VibratePop();
            particleController.transform.position = transform.position;
            particleSystem.Play();
            rb.velocity = new Vector2(0, 0);
            rb.isKinematic = true;
            //Award Diamond
            int awardedDiamond = DBEndlessScore.DBScore / 3;
            GlobalCurrency.AddCurrency(awardedDiamond);
            player.transform.position = spawnPoint;
            deathSound.Play();

            //XP Rewards
            if (DBEndlessScore.DBScore != 0)
            {
                int awardedXP = DBEndlessScore.DBScore / 2;
                GlobalXP.AddXP(awardedXP);
                GlobalXP.AddToTotalXP(awardedXP);
                xpText.text = "+" + awardedXP + "XP";
            }
            TinySauce.OnGameFinished(true, DBEndlessScore.DBScore);

            //Play Again
            camera.transform.SetParent(particalController.transform);
            playAgainCanvas.SetActive(true);
            score.text = DBEndlessScore.DBScore + "";
            diamond.text = "+" + awardedDiamond;
            player.GetComponent<PlayerMovement>().enabled = false;
        }
    }

}
