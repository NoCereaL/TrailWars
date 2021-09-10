using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string level;
    public AudioSource completeSound;
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
        if(collision.collider.tag == "FinishLine")
        {
            //completeSound.Play();
            Vibration.VibrateNope();

            //Award Currency and XP
            GlobalCurrency.AddCurrency(5);
            GlobalXP.AddXP(25);
            GlobalXP.AddToTotalXP(25);

            //Player Stats
            if(PlayerPrefs.GetInt(level) == 0)      //if next Level is locked then this level is complete after completion
            {
                PlayerPrefs.SetInt("ABLevelsComplete", PlayerPrefs.GetInt("ABLevelsComplete") + 1);
                PlayerPrefs.SetInt("LevelsComplete", PlayerPrefs.GetInt("LevelsComplete") + 1);
            }

            SceneManager.LoadScene(level);
        }
    }
}
