using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomView : MonoBehaviour
{
    private RoomTemplates templates;
    // Start is called before the first frame update
    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        // print(templates.found);
    }

    // Update is called once per frame
    void Update()
    {
        print(templates.found);
    }
}
