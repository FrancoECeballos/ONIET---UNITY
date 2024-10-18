using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleTreeScript : MonoBehaviour
{
    public GameObject hole;

    // Start is called before the first frame update
    void Start()
    {
        hole.transform.position = new Vector3(
            hole.transform.position.x,
            Random.Range(-3f, 3f),
            hole.transform.position.z
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}