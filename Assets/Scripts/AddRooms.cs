using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRooms : MonoBehaviour
{
    //Attached to every room prefab
    private RoomTemplates templates;
    // Start is called before the first frame update
    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        templates.rooms.Add(this.gameObject);
    }

    // Update is called once per frame
}
