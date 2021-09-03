using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockLevel : MonoBehaviour
{
    private GameObject player;
    public string levelName;
    private NextLevel next;
    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
        next = this.gameObject.GetComponent<NextLevel>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.name == "CSPlayer")
        {
            levelName = player.GetComponent<CSNextLevel>().level;
        }
        if (player.name == "DBPlayer")
        {
            levelName = player.GetComponent<DBNextLevel>().level;
        }
        else
        {
            levelName = next.level;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "FinishLine")
        {
            PlayerPrefs.SetInt(levelName, 1);
        }
    }

}
