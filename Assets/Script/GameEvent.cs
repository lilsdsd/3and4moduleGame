using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : MonoBehaviour
{
    public static GameEvent current;
    // Start is called before the first frame update
    private void Awake(){
        current = this;
    }

    public event Action onDoorwayTriggerEnter;
    public void DoorwayTriggerEnter()
    {
        if (onDoorwayTriggerEnter != null)
        {
            onDoorwayTriggerEnter();
        }
    }
    public event Action onDoorwayTriggerExit;
    public void DoorwayTriggerExit()
    {
        if (onDoorwayTriggerExit != null)
        {
            onDoorwayTriggerExit();
        }
    }

}
