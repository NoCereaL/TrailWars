using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DBNextLevel : MonoBehaviour
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
            GlobalCurrency.AddCurrency(5);
            GlobalXP.AddXP(25);
            GlobalXP.AddToTotalXP(25);
            SceneManager.LoadScene(level);
        }
    }
}
