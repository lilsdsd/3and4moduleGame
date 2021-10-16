using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private void Start()
    {

        GameEvent.current.onDoorwayTriggerEnter += OnDoorwayOpen;
        GameEvent.current.onDoorwayTriggerEnter += OnDoorwayClose;
    }


     private void OnDoorwayClose()
    {
        //LeanTween.moveLocalY(gameObject, 75f, 1f).setEasQutquad();
        Debug.Log("OnDoorWayclose triggered");
        
    }

    private void OnDoorwayOpen()
    {
        //LeanTween.moveLocalY(gameObject, 1.6f, 1f).setEasQutquad();
         Debug.Log("OnDoorWayOpen triggered");
    }
}
 