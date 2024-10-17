using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour
{

    public GameObject floor;
    public float speed = 20f;
    public float resetPositionX = 40f;
    public float offscreenPositionX = -47f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * speed) * Time.deltaTime;

        if (floor.transform.position.x < offscreenPositionX)
        {
            floor.transform.position = new Vector3(resetPositionX, floor.transform.position.y, 1.5f);
        }
    }
}
