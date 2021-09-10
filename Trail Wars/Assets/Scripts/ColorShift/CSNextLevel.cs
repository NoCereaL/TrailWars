using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CSNextLevel : MonoBehaviour
{
    public string level;
    public AudioSource successSound;
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

            //Award Currency & XP
            GlobalCurrency.AddCurrency(5);
            GlobalXP.AddXP(25);
            GlobalXP.AddToTotalXP(25);

            //Player Stats
            if (PlayerPrefs.GetInt(level) == 0)      //if next Level is locked then this level is complete after completion
            {
                PlayerPrefs.SetInt("CSLevelsComplete", PlayerPrefs.GetInt("CSLevelsComplete") + 1);
                PlayerPrefs.SetInt("LevelsComplete", PlayerPrefs.GetInt("LevelsComplete") + 1);
            }

            SceneManager.LoadScene(level);
        }
    }
}
