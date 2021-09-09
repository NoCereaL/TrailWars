using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCSEndlessScript : MonoBehaviour
{
    private Transform player;
    private Transform obstacle;
    private GameObject nextPoint;

    private Vector3 spawnPoint;

    private GameObject gameContainer;
    public GameObject[] gameObjects;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("CSPlayer").GetComponent<Transform>();
        obstacle = this.gameObject.GetComponent<Transform>();
        nextPoint = this.gameObject;
        gameContainer = GameObject.Find("GameContainer");
        spawnPoint = new Vector3(transform.position.x, transform.position.y - 5, transform.position.z);
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
        int rand = Random.Range(0,gameObjects.Length);
        if (player.position.y < obstacle.position.y + 4)
        {
            Instantiate(gameObjects[rand], spawnPoint, Quaternion.identity, gameContainer.transform);
            //nextPoint.GetComponent<SpriteRenderer>().color = newColor;
            this.gameObject.GetComponent<NewCSEndlessScript>().enabled = false;
        }
    }
}
