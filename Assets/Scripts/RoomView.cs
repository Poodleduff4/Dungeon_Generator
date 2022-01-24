using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapView : MonoBehaviour
{
    private RoomTemplates templates;
    // Start is called before the first frame update
    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        // print(templates.found);
        // Camera.main.
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X)){
            print("Map");
            SceneManager.LoadScene(sceneName:"Main");
        }
    }
}
