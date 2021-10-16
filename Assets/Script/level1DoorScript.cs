using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1DoorScript : MonoBehaviour
{

    public GameObject LevelLoader;
    public GameObject theTransText;
    public GameObject Joystick;

    void OnTriggerEnter2D(Collider2D other) {
        // if(other.CompareTag("InterObject"))
        if(other.CompareTag("Player")){
            Debug.Log("player contect the door");
            Joystick.SetActive(false);
            LevelLoader.SetActive(true);
            LevelLoader.GetComponent<LevelLoader>().LoadNextLevel();
            theTransText.SetActive(true);
            
        }
    }
}
