using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAgainScript : MonoBehaviour
{
    public GameObject playAgainCanvas;
    public GameObject camera;
    public GameObject cameraHolder;
    public GameObject player;
    public Rigidbody2D rb;
    public void PlayAgain()
    {
        playAgainCanvas.SetActive(false);
        Time.timeScale = 1;
        ABEndlessScore.ABScore = 0;
        CSEndlessScore.CSScore = 0;
        camera.transform.SetParent(cameraHolder.transform);
        rb.isKinematic = false;
        if(player.GetComponent<PlayerMovement>() != null)
        {
            player.GetComponent<PlayerMovement>().enabled = true;
        }
        if (player.GetComponent<PlayerCSMovement>() != null)
        {
            player.GetComponent<PlayerCSMovement>().enabled = true;
        }
        if(player.GetComponent<PlayerDBMovement>() != null)
        {
            player.GetComponent<PlayerDBMovement>().enabled = true;
        }
    }
}
