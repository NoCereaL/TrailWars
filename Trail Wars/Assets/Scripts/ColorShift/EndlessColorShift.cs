using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessColorShift : MonoBehaviour
{
    private GameObject player;
    private GameObject obstacle;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("CSPlayer");
        obstacle = this.gameObject;
        spriteRenderer = player.GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Color[] colors = { Color.red, Color.green, Color.blue };

            if (spriteRenderer != null)
            {

                Color newColor = colors[(int)Random.Range(0, 3)];

                spriteRenderer.color = newColor;
            }
            this.gameObject.GetComponent<EndlessColorShift>().enabled = false;
        }

    }
}
