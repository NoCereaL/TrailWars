using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class DBEndlessScript : MonoBehaviour
{
    private Transform player;
    private Transform obstacle;
    private GameObject nextPoint;

    private Vector3 spawnPoint;

    private GameObject gameContainer;
    private int randomScale;
    private int randomPosition;
    private Light2D light;

    //Array of Scales and Positions
    private float[] objScale = {2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8};
    private float[] objPosition = {6.5f, -6.5f, 6, -6, 5.5f, -5.5f, -5, 5, 4.5f, -4.5f, -4, 4, 3.5f, -3.5f };
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("DBPlayer").GetComponent<Transform>();
        obstacle = this.gameObject.GetComponent<Transform>();
        nextPoint = this.gameObject;
        gameContainer = GameObject.Find("GameContainer");
        spawnPoint = new Vector3(transform.position.x, transform.position.y - 4, transform.position.z);
        randomScale = Random.Range(0, 6);
        randomPosition = Random.Range(-1, 1);
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
        if (player.position.y < obstacle.position.y + 8)
        {
            int randomInt = Random.Range(0, 10);
            Instantiate(nextPoint, spawnPoint, Quaternion.identity, gameContainer.transform);
            //nextPoint.transform.localScale = new Vector3(objScale[randomInt], nextPoint.transform.localScale.y, nextPoint.transform.localScale.z) ;
            //nextPoint.transform.localPosition = new Vector3(objPosition[randomInt], spawnPoint.y, nextPoint.transform.position.z);
            DBEndlessScore.DBScore++;
            this.gameObject.GetComponent<DBEndlessScript>().enabled = false;
        }
    }
}
