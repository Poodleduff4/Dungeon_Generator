using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private RoomTemplates templates;
    // Start is called before the first frame update
    void Start()
    {
        print("Player");
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
    }

    // Update is called once per frame
    void move(){
        if(Input.GetKeyDown(KeyCode.Space)){
            
        }
    }

    void OnTriggerStay2D(Collider2D other){
        print(other.gameObject);
    }
}
