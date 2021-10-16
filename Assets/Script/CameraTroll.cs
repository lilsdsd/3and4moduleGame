using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTroll : MonoBehaviour
{
  
   public Transform camtroll; 


    void Start() {
        camtroll = GetComponent<Transform>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        camtroll.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y ,0);
    }
}
