using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRotatingObject : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Rigidbody2D rb;
    public Rigidbody2D rb1;
    public Rigidbody2D rb2;
    public Rigidbody2D rb3;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = this.gameObject.GetComponent<BoxCollider2D>();
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, 0);
        rb1.velocity = new Vector2(speed, 0);
        rb2.velocity = new Vector2(speed, 0);
        rb3.velocity = new Vector2(speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "border")
        {
            speed = -speed;
        }
    }
}
