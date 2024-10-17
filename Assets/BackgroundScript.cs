using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    public GameObject background;
    public Rigidbody2D backgroundRB;
    public float speed = 0.5f;
    public float resetPositionX = 28.11f;
    public float offscreenPositionX = -30f;
    void Start()
    {
        backgroundRB.velocity = Vector2.left * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (background.transform.position.x < offscreenPositionX)
        {
            background.transform.position = new Vector3(resetPositionX, background.transform.position.y, background.transform.position.z);
        }
    }
}
