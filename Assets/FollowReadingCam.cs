using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowReadingCam : MonoBehaviour
{
    public bool isReading = false;
    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;
    float curZoomPos;
    float  zoomTo = 120f; // curZoomPos will be the value
    float zoomFrom = 20f; //Midway point between nearest and farthest zoom values (a "starting position")
    public Camera CameraObject;
     // Update is called once per frame

void Start(){
    curZoomPos = 120;
}

     void Update() 
     {
        if(isReading == true){

            if (target)
            {
                Vector3 point = GetComponent<Camera>().WorldToViewportPoint(target.position);
                Vector3 delta = target.position - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
                Vector3 destination = transform.position + delta;
                transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
            }
            // Attaches the float y to scrollwheel up or down
         
            if(zoomTo > 60) {
                // If the wheel goes up it, decrement 5 from "zoomTo"
                zoomTo -= 0.5f;
                Debug.Log ("Zoomed In");

            }else if(zoomTo < 60){
               zoomTo = 60;
           }
   
        }else if(isReading == false){

           if (zoomTo < 120) {
                // If the wheel goes down, increment 5 to "zoomTo"
                zoomTo += 0.5f;
                Debug.Log ("Zoomed Out");

           }else if (zoomTo > 120){
               zoomTo = 120;
           }

        }

        // creates a value to raise and lower the camera's field of view
         //curZoomPos =  zoomFrom + zoomTo;
         
         //curZoomPos = Mathf.Clamp (curZoomPos, 5f, 35f);
         
         // Stops "zoomTo" value at the nearest and farthest zoom value you desire
         //zoomTo = Mathf.Clamp (zoomTo, -15f, 30f);
         
         // Makes the actual change to Field Of View
         //Camera.main.fieldOfView = curZoomPos;
         CameraObject.orthographicSize = zoomTo;
     }

    public void Reading(){
        isReading = true;
     }
    public void UnReading(){
        isReading = false;
     }
}
