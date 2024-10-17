using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour
{

    public GameObject floor;
    public Rigidbody2D floorRB;
    public float speed = 0.5f;
    public float resetPositionX = 15f;
    public float offscreenPositionX = -24f;

    // Start is called before the first frame update
    void Start()
    {
        floorRB.velocity = Vector2.left * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (floor.transform.position.x < offscreenPositionX)
        {
            floor.transform.position = new Vector3(resetPositionX, floor.transform.position.y, 0);
        }
    }
}
