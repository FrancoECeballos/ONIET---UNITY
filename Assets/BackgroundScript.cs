using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    public GameObject background;
    public Rigidbody2D backgroundRB;
    public float speed = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        backgroundRB.velocity = Vector2.left * speed;
    }
}
