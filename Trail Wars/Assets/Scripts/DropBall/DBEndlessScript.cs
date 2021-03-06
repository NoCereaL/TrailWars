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
    private Light2D light;

    public GameObject[] obstacles;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("DBPlayer").GetComponent<Transform>();
        obstacle = this.gameObject.GetComponent<Transform>();
        nextPoint = this.gameObject;
        gameContainer = GameObject.Find("GameContainer");
        spawnPoint = new Vector3(transform.position.x, transform.position.y - 4, transform.position.z);
        randomScale = Random.Range(0, 6);
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
        int rand = Random.Range(0, obstacles.Length);
        if (player.position.y < obstacle.position.y + 8)
        {
            Instantiate(obstacles[rand], spawnPoint, Quaternion.identity, gameContainer.transform);
            this.gameObject.GetComponent<DBEndlessScript>().enabled = false;
        }
    }
}
