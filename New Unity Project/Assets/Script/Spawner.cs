using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int openingDir;
    //1->bottom door
    //2->top door
    //3->left door
    //4->right door

    private RoomTemplate templates;
    private int rand;
    private bool spawned = false;

    public float waitTime = 4f;

    void Start()
    {
        Destroy(gameObject, waitTime);
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplate>();
        Invoke("Spawn", 0.1f);
    }

    // Update is called once per frame
    
    public void Spawn()
    {
        if (spawned == false)
        {
            if (openingDir == 2)
            {
                //Spawn a bottom door
                rand = Random.Range(0, templates.bottemRooms.Length);
                Instantiate(templates.bottemRooms[rand], transform.position, Quaternion.identity);
            }
            else if (openingDir == 1)
            {
                //Spawn a top door
                rand = Random.Range(0, templates.upperRooms.Length);
                Instantiate(templates.upperRooms[rand], transform.position, Quaternion.identity);
            }
            else if (openingDir == 3)
            {
                //Spawn a right door
                rand = Random.Range(0, templates.rightRooms.Length);
                Instantiate(templates.rightRooms[rand], transform.position, Quaternion.identity);
            }
            else if (openingDir == 4)
            {
                //Spawn a left door
                rand = Random.Range(0, templates.leftRooms.Length);
                Instantiate(templates.leftRooms[rand], transform.position, Quaternion.identity);
            }

            spawned = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SpawnPoint"))
        {
            if (other.GetComponent<Spawner>().spawned == false && spawned == false)
            {
                Instantiate(templates.closedRoom, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            spawned = true;
        }
    }
}
