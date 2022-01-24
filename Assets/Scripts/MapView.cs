using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if(Input.GetKeyDown(KeyCode.X)){
            // templates.currentRoom = 
            print("Room");
            SceneManager.LoadScene(sceneName:"Room View", LoadSceneMode.Additive);
        }
    }
}
