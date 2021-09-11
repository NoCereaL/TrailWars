using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DBNextLevel : MonoBehaviour
{
    public string level;
    public AudioSource successSound;
    public AudioSource completeSound;
    public GameObject rewardCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Vibration.Init();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "FinishLine")
        {
            //successSound.Play();
            Vibration.VibrateNope();

            //Award Currency and XP
            if (PlayerPrefs.GetInt(level) == 0)
            {
                GlobalCurrency.AddCurrency(10);
                GlobalXP.AddXP(25);
                GlobalXP.AddToTotalXP(25);
            }
            else
            {
                GlobalCurrency.AddCurrency(5);
                GlobalXP.AddXP(10);
                GlobalXP.AddToTotalXP(10);
            }
            //Player Stats
            if (PlayerPrefs.GetInt(level) == 0)      //if next Level is locked then this level is complete after completion
            {
                PlayerPrefs.SetInt("DBLevelsComplete", PlayerPrefs.GetInt("DBLevelsComplete") + 1);
                PlayerPrefs.SetInt("LevelsComplete", PlayerPrefs.GetInt("LevelsComplete") + 1);
            }
            rewardCanvas.SetActive(true);
            DontDestroyOnLoad(rewardCanvas);
            SceneManager.LoadScene(level);
        }
    }
}
