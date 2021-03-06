using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openingDirection;
    private RoomTemplates templates;
    private int rand;
    private bool spawned = false;

    // 1 --> top door
    // 2 --> bottom door
    // 3 --> left door
    // 4 --> right door

    // Start is called before the first frame update
    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn", 0.1f);
        Camera.main.orthographicSize += 1;
    }

    // Update is called once per frame
    void Spawn()
    {
        if (spawned == false)
        {
            if (openingDirection == 1)
            {
                // spawn top door
                rand = randNumPreferHigh(0, templates.topRooms.Length);
                Instantiate(templates.topRooms[rand], gameObject.transform.position, templates.topRooms[rand].transform.rotation);
            }
            else if (openingDirection == 2)
            {
                // spawn bottom door
                rand = randNumPreferHigh(0, templates.bottomRooms.Length);
                Instantiate(templates.bottomRooms[rand], gameObject.transform.position, templates.bottomRooms[rand].transform.rotation);
            }
            else if (openingDirection == 3)
            {
                // spawn left door
                rand = randNumPreferHigh(0, templates.leftRooms.Length);
                Instantiate(templates.leftRooms[rand], gameObject.transform.position, templates.leftRooms[rand].transform.rotation);
            }
            else if (openingDirection == 4)
            {
                // spawn right door
                rand = randNumPreferHigh(0, templates.rightRooms.Length);
                Instantiate(templates.rightRooms[rand], gameObject.transform.position, templates.rightRooms[rand].transform.rotation);
            }
            // if(openingDirection == 5)
            // {
            //     Instantiate(templates.rightRooms[0], gameObject.transform.position, templates.rightRooms[0].transform.rotation);
            // }
            spawned = true;
        }

    }

    int randNumPreferHigh(int low, int high){
        int rand = Random.Range(0, high);
        if(rand == 0){
            rand = Random.Range(0, high);
        }
        return rand;
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("SpawnPoint")){
            if(other.GetComponent<RoomSpawner>().spawned == false && spawned == false){
                Instantiate(templates.closedRoom, gameObject.transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            spawned = true;
        }
    }
}
