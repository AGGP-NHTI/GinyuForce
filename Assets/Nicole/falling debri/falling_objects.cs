using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling_objects : MonoBehaviour
{
    //length to right
    [SerializeField]
    private float limit;
    //amount of spawners and their x-locations
    [SerializeField]
    private float[] positions;
    //enemy prefab holders
    [SerializeField]
    private GameObject[] enemyPrefabs;
    //amount of falling
    [SerializeField]
    private Wave[] wave;

    private float currentTime;

    List<float> remainingPosition = new List<float>();
    private int waveIndex;
    float xPositions = 0;
    int rand;


    void Start()
    {
        currentTime = 0;
        remainingPosition.AddRange(positions);
    }


    void Update()
    {
        
         //if statement == true, set currentTime -= Time.deltaTime
        
        if (currentTime <= 0)
        {
            SelectWave();
        }
         
         
    }

    void SpawnObject(float xPosition)
    {
        int r = Random.Range(0, 3); //3 types of falling entities
        GameObject enemyObject = Instantiate(enemyPrefabs[r], new Vector3(xPosition, transform.position.y, 0), Quaternion.identity);
    }

    void SelectWave()
    {
        remainingPosition = new List<float>();
        remainingPosition.AddRange(positions);

        waveIndex = Random.Range(0, wave.Length);

        currentTime = wave[waveIndex].delayTime;

        if (wave[waveIndex].spawnAmount ==1)
        {
            xPositions = Random.Range(-limit, limit);
        }
        else if (wave[waveIndex].spawnAmount > 1)
        {
            rand = Random.Range(0, remainingPosition.Count);
            xPositions = remainingPosition[rand];
            remainingPosition.RemoveAt(rand);
        }

        for (int i = 0; i < wave[waveIndex].spawnAmount; i++)
        {
            SpawnObject(xPositions);
            rand = Random.Range(0, remainingPosition.Count);
            xPositions = remainingPosition[rand];
            remainingPosition.RemoveAt(rand);
        }
    }
}

//timer between spawns
//amount spawned
[System.Serializable]
public class Wave
{
    public float delayTime;
    public float spawnAmount;
}