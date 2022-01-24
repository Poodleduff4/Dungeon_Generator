using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    public GameObject[] topRooms;
    public GameObject[] bottomRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;
    public GameObject closedRoom;
    public List<GameObject> rooms;
    public Sprite[] sprites;
    public Material[] mats;
    public GameObject player;
    public GameObject boss;
    public bool bossSpawned = false;
    public float timeSinceSpawn;
    public int found = 1;
    public GameObject currentRoom;
    public bool done = false;

    void Start(){
        // Instantiate(player, new Vector3(0, 0, 0), Quaternion.identity);
        // currentRoom = rooms[0];
    }

    // void FixedUpdate(){
    //     timeSinceSpawn += Time.fixedDeltaTime;
    //     if(timeSinceSpawn > 1 && !bossSpawned){
    //         print("BOSS");
    //         timeSinceSpawn = 0;
    //         bossSpawned = true;
    //         Instantiate(boss, rooms[rooms.Count-1].transform.position, rooms[rooms.Count-1].transform.rotation);
    //         done = true;
            
    //     }
    // }
}