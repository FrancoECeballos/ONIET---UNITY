using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    public GameObject background1;
    public GameObject background2;
    public Rigidbody2D backgroundRB1;
    public Rigidbody2D backgroundRB2;
    public float speed = 0.5f;
    private Camera mainCamera;
    private float backgroundWidth;

    void Start()
    {
        mainCamera = Camera.main;
        backgroundWidth = background1.GetComponent<SpriteRenderer>().bounds.size.x;

        backgroundRB1.velocity = Vector2.left * speed;
        backgroundRB2.velocity = Vector2.left * speed;
    }

    void Update()
    {
        float offscreenPositionX = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x - backgroundWidth / 2;
        float resetPositionX = mainCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x + backgroundWidth / 2;

        if (background1.transform.position.x < offscreenPositionX)
        {
            background1.transform.position = new Vector3(resetPositionX, background1.transform.position.y, background1.transform.position.z);
        }

        if (background2.transform.position.x < offscreenPositionX)
        {
            background2.transform.position = new Vector3(resetPositionX, background2.transform.position.y, background2.transform.position.z);
        }
    }
}