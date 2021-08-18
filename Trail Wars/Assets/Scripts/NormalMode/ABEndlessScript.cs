using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABEndlessScript : MonoBehaviour
{
    public Transform player;
    public Transform obstacle;
    public Transform nextPoint;
    public Vector3 spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("ABPlayer").GetComponent<Transform>();
        obstacle = this.gameObject.GetComponent<Transform>();
        nextPoint = this.gameObject.GetComponentInChildren<Transform>().Find("NextPoint");

        //SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObstacle()
    {
        spawnPoint = new Vector3(transform.position.x, transform.position.y + 8, transform.position.z);
        Instantiate(obstacle, nextPoint.position, Quaternion.identity);
    }
}
