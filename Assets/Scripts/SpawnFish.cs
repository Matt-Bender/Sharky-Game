using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFish : MonoBehaviour
{
    [SerializeField] private GameObject goodFish;
    [SerializeField] private GameObject badFish;

    //Changes the amount of time between each fish is spawned
    [SerializeField] private float timeBetweenSpawns;
    //Is set to timeBetweenSpawns and counts down using Time.deltaTime each update
    private float timeRemaining;

    //tracks number of fish spawned to cap it at 100
    private int spawnedfish = 0;
    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = timeBetweenSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnedfish < 100)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                //Debug.Log("Fish Spawned");
                timeRemaining = timeBetweenSpawns;
                //Creates a random number from 0-3 if its 0 spawns bad fish otherwise spawns good fish
                //Makes it a quarter chance to spawn bad and 3 quarter to spawn good
                GameObject fishToSpawn;
                int randNum = Random.Range(0, 4);
                //Debug.Log(randNum);
                if (randNum == 0)
                {
                    fishToSpawn = badFish;
                }
                else
                {
                    fishToSpawn = goodFish;
                }
                Instantiate(fishToSpawn, new Vector3(transform.position.x, Random.Range(-15, 13), transform.position.z), transform.rotation);
                spawnedfish++;
            }
        }
        else
        {
            Debug.Log("Finished Spawning");
        }

    }

    public void SpawnMoreFish()
    {
        spawnedfish = 0;
    }
}
