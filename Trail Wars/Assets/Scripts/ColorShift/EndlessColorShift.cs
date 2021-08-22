using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessColorShift : MonoBehaviour
{
    public GameObject player;
    public GameObject obstacle;
    public SpriteRenderer spriteRenderer;
    public Transform changeColorPoint;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("CSPlayer");
        obstacle = this.gameObject;
        spriteRenderer = player.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y < changeColorPoint.position.y)
        {
            Color[] colors = { Color.red, Color.green, Color.blue };

            if (spriteRenderer != null )
            {

                Color newColor = colors[(int)Random.Range(0, 3)];

                spriteRenderer.color = newColor;
            }
            this.gameObject.GetComponent<EndlessColorShift>().enabled = false;
        }
    }
}
