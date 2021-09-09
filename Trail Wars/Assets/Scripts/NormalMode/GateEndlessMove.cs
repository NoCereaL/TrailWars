using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateEndlessMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Rigidbody2D rb1;
    public Rigidbody2D rb2;

    public int xSpeed;
    // Start is called before the first frame update
    void Start()
    {
        if(ABEndlessScore.ABScore >= 50)
        {
            xSpeed = Random.Range(3, 5);
        }
        else if (ABEndlessScore.ABScore >= 100)
        {
            xSpeed = Random.Range(5, 6);
        }
        else
        {
            xSpeed = Random.Range(1, 3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Move();
        AutoMove();
    }

    /*
    public void Move()
    {
        Vector3 playerMove = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.position += playerMove * speed * Time.deltaTime;
    }
    */

    public void AutoMove()
    {
        rb.velocity = new Vector2(xSpeed, 0);
        rb1.velocity = new Vector2(xSpeed, 0);
        rb2.velocity = new Vector2(xSpeed, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "border")
        {
            xSpeed = -xSpeed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "border")
        {
            xSpeed = -xSpeed;
        }
    }
}
