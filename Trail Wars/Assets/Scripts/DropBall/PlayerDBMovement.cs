using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDBMovement : MonoBehaviour
{
    public Vector3 position;
    public Rigidbody2D rb;
    public float fallSpeed;
    public float velocity;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        velocity = rb.velocity.y;
        RestrictSpeed();
        Move();
    }

    public void Move()
    {
        Touch touch = Input.GetTouch(0);
        position = Camera.main.ScreenToWorldPoint(touch.position);
        transform.position = new Vector3(position.x, transform.position.y, transform.position.z);

    }

    public void RestrictSpeed()
    {
        //rb.velocity = Vector3.ClampMagnitude(rb.velocity, 1);
        if (rb.velocity.y <= -fallSpeed)
        {
            rb.velocity = new Vector2(rb.velocity.x, -fallSpeed);
        }
    }

    public void TempMove()
    {
        Vector3 temp = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += temp * speed * Time.deltaTime;
    }
}
