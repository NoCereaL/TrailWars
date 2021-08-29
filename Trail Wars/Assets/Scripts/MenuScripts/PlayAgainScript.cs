using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAgainScript : MonoBehaviour
{
    public GameObject playAgainCanvas;
    public void PlayAgain()
    {
        playAgainCanvas.SetActive(false);
        Time.timeScale = 1;
        ABEndlessScore.ABScore = 0;
    }
}
