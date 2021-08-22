using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABEndlessScript : MonoBehaviour
{
    private Transform player;
    private Transform obstacle;
    private GameObject nextPoint;

    private Vector3 spawnPoint;

    private GameObject gameContainer;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("ABPlayerEndless").GetComponent<Transform>();
        obstacle = this.gameObject.GetComponent<Transform>();
        nextPoint = this.gameObject;
        gameContainer = GameObject.Find("GameContainer");
        spawnPoint = new Vector3(transform.position.x, transform.position.y + 4, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        SpawnObstacle();
    }

    private void FixedUpdate()
    {
        //SpawnObstacle();
    }

    public void SpawnObstacle()
    {
       if(player.position.y > obstacle.position.y - 4)
        {
            Instantiate(nextPoint, spawnPoint, Quaternion.identity, gameContainer.transform);
            ABEndlessScore.ABScore++;
            this.gameObject.GetComponent<ABEndlessScript>().enabled = false;
        }
    }
}
