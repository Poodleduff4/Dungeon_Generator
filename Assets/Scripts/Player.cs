using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private RoomTemplates templates;
    // private GameObject currentRoom;
    // Start is called before the first frame update
    void Start()
    {
        print("Player");
        gameObject.tag = "Player";
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        // Instantiate(templates.player, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            templates.currentRoom = FindRoom(gameObject);
            print(templates.currentRoom);
        }
        //1 has door facing the top, so to move into that room, we need to go down 1
        //2 --> room above
        //1 --> room below
        //3 --> room to the right
        //4 --> room to the left
        if(Input.GetKeyDown(KeyCode.W)){
            Move(2);
        }
        else if(Input.GetKeyDown(KeyCode.S)){
            Move(1);
        }
        else if(Input.GetKeyDown(KeyCode.A)){
            Move(4);
        }
        else if(Input.GetKeyDown(KeyCode.D)){
            Move(3);
        }
        
    }

    void Move(int dir){
        RoomSpawner[] spawnPoints = FindRoom(gameObject).GetComponentsInChildren<RoomSpawner>();
        print(spawnPoints.Length);
        for(int i = 0;i < spawnPoints.Length;i++){
            //room with door opening down, connecting from above
            if(spawnPoints[i].openingDirection == dir){
                gameObject.transform.position = spawnPoints[i].transform.position;
            }
        }
        templates.currentRoom = FindRoom(gameObject);
    }

    GameObject FindRoom(GameObject target){
        for(int i = 0;i < templates.rooms.Count;i++){
            GameObject room = templates.rooms[i];
            if((target.transform.position - room.transform.position).magnitude < 4){
                // print(room);
                return room;
            }
        }
        return null;
    }
}
