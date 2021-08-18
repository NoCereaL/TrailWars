using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RGBPlayerMovement : MonoBehaviour
{
    public GameObject player;
 
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("RGBPlayer");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Red()
    {
        player.transform.position = new Vector3(-3f/2, player.transform.position.y, player.transform.position.z);
    }

    public void Green()
    {
        player.transform.position = new Vector3(0, player.transform.position.y, player.transform.position.z);
    }

    public void Blue()
    {
        player.transform.position = new Vector3(3f / 2, player.transform.position.y, player.transform.position.z);
    }
}
