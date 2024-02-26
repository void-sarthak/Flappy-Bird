using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    float timer = 0f;
    float spawnTime = 2.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obstacle, new Vector3(10, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > spawnTime)
        {
            Instantiate(obstacle, new Vector3(10, Random.Range(-3, 3), 0), Quaternion.identity);
            timer = 0;
            spawnTime = Random.Range(1, 4);
        }

        timer += Time.deltaTime;
    }
}
