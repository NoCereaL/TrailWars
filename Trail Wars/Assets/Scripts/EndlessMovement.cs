using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public int xSpeed;
    // Start is called before the first frame update
    void Start()
    {
        xSpeed = Random.Range(2, 10);
    }

    // Update is called once per frame
    void Update()
    {
        AutoMove();
    }

    public void AutoMove()
    {
        rb.velocity = new Vector2(xSpeed, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "border")
        {
            xSpeed = -xSpeed;
        }
    }
}
