using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSInvincibility : MonoBehaviour
{
    private GameObject player;
    public Transform powerUp;
    private SpriteRenderer spriteRenderer;
    private Color[] colors;
    int x;
    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
        spriteRenderer = player.GetComponent<SpriteRenderer>();
        colors[0] = Color.red;
        colors[1] = Color.green;
        colors[2] = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "powerup")
        {
            powerUp = collision.transform;
            Destroy(powerUp);
            StartCoroutine(Invincibility());
        }
    }

    IEnumerator Invincibility()
    {
        player.GetComponent<CircleCollider2D>().enabled = false;
        player.GetComponent<BrokenLight>().enabled = true;
        yield return new WaitForSeconds(3);
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(1);
        player.GetComponent<BrokenLight>().enabled = false;
        player.GetComponent<CircleCollider2D>().enabled = true;
    }
}
