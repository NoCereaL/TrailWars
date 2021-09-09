using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDBEndlessMovement : MonoBehaviour
{
    public Vector3 position;
    public Rigidbody2D rb;
    public float fallSpeed;
    public float velocity;
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
        IncreaseSpeed();
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

    public void IncreaseSpeed()
    {
        switch (DBEndlessScore.DBScore)
        {
            case 0:
                fallSpeed = 5;
                break;
            case 20:
                fallSpeed = 6;
                break;
            case 30:
                fallSpeed = 7;
                break;
            case 40:
                fallSpeed = 8;
                break;
            case 50:
                fallSpeed = 9;
                break;
            case 60:
                fallSpeed = 10;
                break;
            case 70:
                fallSpeed = 11;
                break;
            case 80:
                fallSpeed = 12;
                break;
            case 90:
                fallSpeed = 13;
                break;
            case 100:
                fallSpeed = 15;
                break;
        }
    }
}
