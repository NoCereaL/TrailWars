using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpHeight;
    public float maxSpeed;
    public float maxRotationalSpeed;
    public float velocity;
    public AudioSource audioSource;
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
            int[] directions = { -2, -1, 1, 2 };
            int randomNum = Random.Range(0, 3);
            rb.AddTorque(directions[randomNum]);
            audioSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
            audioSource.Play();
        }
    }

    public void RestrictSpeed()
    {
        //rb.velocity = Vector3.ClampMagnitude(rb.velocity, 1);
        if (rb.velocity.y >= maxSpeed)
        {
            rb.velocity = new Vector2(rb.velocity.x, maxSpeed);
        }
    }
}
