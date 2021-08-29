using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAgainScript : MonoBehaviour
{
    public GameObject playAgainCanvas;
    public GameObject camera;
    public GameObject cameraHolder;
    public GameObject player;
    public void PlayAgain()
    {
        playAgainCanvas.SetActive(false);
        Time.timeScale = 1;
        ABEndlessScore.ABScore = 0;
        camera.transform.SetParent(cameraHolder.transform);
        player.GetComponent<PlayerMovement>().enabled = true;
    }
}
