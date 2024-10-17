using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFloor : MonoBehaviour
{
    public GameObject emptyObject;
    public GameObject fullTree;
    public float spawnRate = 1;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEmptyObject();
    }

    // Update is called once per frame
    void Update()
    {
        float random = Random.Range(1, 2);

        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            if (random == 1)
            {
                SpawnEmptyObject();
                timer = 0;
            }
            else if (random == 2)
            {
                SpawnFullTree();
                timer = 0;
            }
            
        }
    }

    void SpawnEmptyObject()
    {
        Instantiate(emptyObject, new Vector3(transform.position.x, (float)-4.5, 0), transform.rotation);
    }

    void SpawnFullTree()
    {
        Instantiate(fullTree, new Vector3(transform.position.x, (float)-4.5, 0), transform.rotation);
    }
}
