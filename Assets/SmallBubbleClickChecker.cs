using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBubbleClickChecker : MonoBehaviour
{
    public bool isClicked ;
    public void Clicked(){
        isClicked = true;
        Debug.Log("buttonPressed");
    }
}
