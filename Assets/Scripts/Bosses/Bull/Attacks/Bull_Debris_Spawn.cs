using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code adapted from Nicole's "falling_objects" script

public class Bull_Debris_Spawn : Actor
{
    //length to right
    [SerializeField]
    private float limit = 0;
    //amount of spawners and their x-locations
    [SerializeField]
    private float[] positions = null;
    //enemy prefab holders
    [SerializeField]
    private GameObject[] enemyPrefabs = null;
    //amount of falling
    [SerializeField]
    private Wave[] wave = null;

    [SerializeField]
    protected float maxWaves = 2;

    private float currentTime = 0;

    private float targetPosition = 0;

    List<float> remainingPosition = new List<float>();
    private int waveIndex;
    float xPositions = 0;
    int rand;


    void Awake()
    {
        remainingPosition.AddRange(positions);
        targetPosition = GameInstanceManager.Main.ThePlayer.Location.x;

        maxWaves = Random.Range(5, 7);
    }


    void Update()
    {

        //if statement == true, set currentTime -= Time.deltaTime

        if(maxWaves <= 0)
        {
            Destroy(gameObject);
        }

        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            targetPosition = GameInstanceManager.Main.ThePlayer.Location.x;
            SelectWave();
        }
    }

    void SpawnObject(float xPosition)
    {
        int r = Random.Range(0, enemyPrefabs.Length); 
        
        GameObject debris = Spawner(enemyPrefabs[r], new Vector3(xPosition, 5, 0), Quaternion.identity, Owner);

        if(Random.Range(1,5) % 2 == 0)
        {
            Vector3 temp = new Vector3(transform.localScale.x * -1f, transform.localScale.y, transform.localScale.z);

            debris.transform.localScale = temp;
        }
    }

    void SelectWave()
    {
        remainingPosition = new List<float>();
        remainingPosition.AddRange(positions);

        waveIndex = Random.Range(0, wave.Length);

        currentTime = wave[waveIndex].delayTime;

        if (wave[waveIndex].spawnAmount == 1)
        {
            xPositions = Random.Range(targetPosition - limit, targetPosition + limit);
        }
        else if (wave[waveIndex].spawnAmount > 1)
        {
            rand = Random.Range(0, remainingPosition.Count);
            xPositions = targetPosition + remainingPosition[rand];
            remainingPosition.RemoveAt(rand);
        }

        for (int i = 0; i < wave[waveIndex].spawnAmount; i++)
        {
            SpawnObject(xPositions);
            rand = Random.Range(0, remainingPosition.Count);
            xPositions = targetPosition + remainingPosition[rand];
            remainingPosition.RemoveAt(rand);
        }

        maxWaves -= 1;
    }
}