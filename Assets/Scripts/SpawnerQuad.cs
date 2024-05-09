using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerQuad : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] numberPrefabs;
    public int[] numberSpanw;
    public float spawnTime;
    private float timeCount; 


    void Start()
    {
        timeCount = spawnTime;
        
    }

    void Update()
    {

        // timeCount += Time.deltaTime;

        if (timeCount <= 0)
        {
            int randNumber = Random.Range(0, numberPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);

            Instantiate(numberPrefabs[randNumber], spawnPoints[randSpawnPoint].position, transform.rotation);
            timeCount = spawnTime;
        }

        else
        {
            timeCount -= Time.deltaTime;
        }

    }
}
