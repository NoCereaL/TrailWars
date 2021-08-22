using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessPanel : MonoBehaviour
{
    public Transform player;
    public GameObject panel;
    public Transform renderPoint;       //The point where an Object new object is spawned
    public Transform spawnPosition;  //Spawnposition of the new Object

    public Vector3 spawnPoint;
    private GameObject gameContainer;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("ABPlayerEndless").GetComponent<Transform>();
        panel = this.gameObject;
        gameContainer = GameObject.Find("GameContainer");
        spawnPoint = spawnPosition.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        SpawnPanel();
    }

    public void SpawnPanel()
    {
        if(player.position.y > renderPoint.position.y)
        {
            GameObject newPanel = Instantiate(panel, spawnPoint, Quaternion.identity, panel.transform);
            newPanel.transform.localScale = new Vector3(1, 1, 1);
            this.gameObject.GetComponent<EndlessPanel>().enabled = false;
        }
    }
}
