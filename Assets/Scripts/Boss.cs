using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private RoomTemplates templates;
    // Start is called before the first frame update
    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        templates.timeSinceSpawn += Time.fixedDeltaTime;
        if(templates.timeSinceSpawn > 1 && !templates.bossSpawned){
            Instantiate(templates.boss, templates.rooms[templates.rooms.Count-1].transform.position, 
                        templates.rooms[templates.rooms.Count-1].transform.rotation);
            print("BOSS");
            templates.timeSinceSpawn = 0;
            templates.bossSpawned = true;
            templates.done = true;
        }
    }
}
