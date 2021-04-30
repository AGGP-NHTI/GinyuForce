using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note_launcher : MonoBehaviour
{
    [SerializeField]
    int ProjectileAmount;

    [SerializeField]
    GameObject musicNotes;

    Vector2 startPoint;

    public float radius = 5f;
    public float moveSpeed = 5f;
    public float repeatRate = 5.0f;

    public int waveTotal;
    public int counter = 0;

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
        
        SpawnNotes(ProjectileAmount);
    }

    void Awake()
    {
        startPoint = transform.position;
    }

    private void Active(Collider other)
    {
        InvokeRepeating("projectile", 0.5f, repeatRate);

        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }


    void SpawnNotes(int ProjectileAmount)
    {

        float angleStep = 360f / ProjectileAmount;
        float angle = 0f;

        for (int i = 0; i <= ProjectileAmount - 1; i++)
        {
            float projectileDirXposition = startPoint.x + Mathf.Sin((angle * Mathf.PI) / 180) * radius;
            float projectileDirYposition = startPoint.x + Mathf.Cos((angle * Mathf.PI) / 180) * radius;

            Vector2 projectileVector = new Vector2(projectileDirXposition, projectileDirYposition);
            Vector2 projectileMoveDirection = (projectileVector - startPoint).normalized * moveSpeed;

            var note = Instantiate(musicNotes, startPoint, Quaternion.identity);
            note.GetComponent<Rigidbody2D>().velocity = new Vector2(projectileMoveDirection.x, projectileMoveDirection.y);

            angle += angleStep;
        }

        counter++;
    }
}
