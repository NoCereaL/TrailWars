using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;

    public int xSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
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
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "border") {
            xSpeed = -xSpeed;
        }
    }

   
}
