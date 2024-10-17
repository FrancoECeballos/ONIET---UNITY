using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFloor : MonoBehaviour
{
    public GameObject holeTree;
    public GameObject worm;
    public float spawnRate = 2;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            int v = Random.Range(1, 4);
            float random = v;
            Debug.Log(random);
            if (random == 1)
            {
                timer = 0;
            }
            else if (random == 2)
            {
                SpawnHoleTree();
                timer = 0;
            }
            else if (random == 3)
            {
                SpawnWorm();
                timer = 0;
            }
            
        }
    }

    void SpawnHoleTree()
    {
        Instantiate(holeTree, new Vector3(transform.position.x, 5, -3), transform.rotation);
    }

    void SpawnWorm()
    {
        Instantiate(worm, new Vector3(transform.position.x, -9, -3), transform.rotation);
    }
}
