using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFloor : MonoBehaviour
{
    public GameObject fullTree;
    public float spawnRate = 1;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float random = Random.Range(1, 3);
        Debug.Log(random);

        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            if (random == 1)
            {
                timer = 0;
            }
            else if (random == 2)
            {
                SpawnFullTree();
                timer = 0;
            }
            
        }
    }

    void SpawnFullTree()
    {
        Instantiate(fullTree, new Vector3(transform.position.x, 1, 0), transform.rotation);
    }
}
