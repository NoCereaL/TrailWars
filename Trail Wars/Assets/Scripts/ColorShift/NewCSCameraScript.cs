using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCSCameraScript : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("CSPlayer");
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    public void FollowPlayer()
    {
        transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z -5);
    }
}
