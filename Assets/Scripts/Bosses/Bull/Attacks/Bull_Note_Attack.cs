using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code adapted from Nicole's "note_launcher" script.

public class Bull_Note_Attack : Actor
{
    [SerializeField]
    int ProjectileAmount = 10;

    [SerializeField]
    GameObject musicNotes = null;

    Vector2 startPoint = Vector2.zero;

    public float radius = 5f;
    public float moveSpeed = 5f;
    public float repeatRate = 5.0f;

    public int waveMinRange = 3;
    public int waveMaxRange = 7;
    protected int waveTotal = 0;
    protected int counter = 0;

    private float repeatCounter = 5f;

    //public Transform spawnPos;

    void Update()
    {
        //float for time total
        //random.range 5-9
        //if 

        

        if (counter >= waveTotal)
        {
            Destroy(gameObject);
        }

        if(repeatCounter >= repeatRate)
        {
            SpawnNotes(ProjectileAmount);
        }
        else
        {
            repeatCounter += Time.deltaTime;
        }
    }

    void Awake()
    {
        startPoint = transform.position;
        waveTotal = Random.Range(waveMinRange, waveMaxRange + 1);
        repeatCounter = repeatRate;
    }

    private void Active(Collider other)
    {
        InvokeRepeating("projectile", 0.5f, repeatRate);

        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }


    void SpawnNotes(int ProjectileAmount)
    {
        repeatCounter = 0f;
        float angle = 0f;

        int actualAmount = ProjectileAmount + Random.Range(-2, 3);

        //float angleStep = 360f / actualAmount;

        for (int i = 0; i < actualAmount; i++)
        {
            angle = Random.Range(-100f, 100f);

            float projectileDirXposition = startPoint.x + Mathf.Sin((angle * Mathf.PI) / 180) * radius;
            float projectileDirYposition = startPoint.y + Mathf.Cos((angle * Mathf.PI) / 180) * radius;

            Vector2 projectileVector = new Vector2(projectileDirXposition, projectileDirYposition);
            Vector2 projectileMoveDirection = (projectileVector - startPoint).normalized * moveSpeed;

            //GameObject note = Instantiate(musicNotes, startPoint, Quaternion.identity);
            GameObject note = Spawner(musicNotes, startPoint, Quaternion.identity, Owner);
            note.GetComponent<Rigidbody2D>().velocity = new Vector2(projectileMoveDirection.x, projectileMoveDirection.y);

            //angle += angleStep;
        }

        counter++;
    }
}
