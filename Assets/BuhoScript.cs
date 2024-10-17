using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuhoScript : MonoBehaviour
{
    public GameObject buho;
    public Rigidbody2D buhoRb;
    public float speed;
    void Start()
    {

    }

    void Update()
    {
        Vector2 newVelocity = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            newVelocity += Vector2.up * speed;
        }   
        if (Input.GetKey(KeyCode.A))
        {
            newVelocity += Vector2.left * speed;
        }   
        if (Input.GetKey(KeyCode.S))
        {
            newVelocity += Vector2.down * speed;
        }   
        if (Input.GetKey(KeyCode.D))
        {
            newVelocity += Vector2.right * speed;
        }

        buhoRb.velocity = Vector2.Lerp(buhoRb.velocity, newVelocity, 0.5f);
    }
}
