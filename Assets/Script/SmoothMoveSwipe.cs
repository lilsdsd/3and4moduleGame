using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothMoveSwipe : MonoBehaviour
{

    private Vector2 startTouchPosition, endTouchPosition;
    private Vector3 startPlayerPosition, endPlayerPosition;//start rocketposition
    private float walkTime; //flytime
    private float walkDuration = 0.1f; //속도? 


    private void Update() 
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            startTouchPosition = Input.GetTouch(0).position;
        
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            if ((endTouchPosition.x < startTouchPosition.x) && transform.position.x > - 1.75f)
                StartCoroutine(Walk("left"));

            if ((endTouchPosition.x > startTouchPosition.x) && transform.position.x < 1.75f)    
                StartCoroutine(Walk("right"));
        }
    }

    private IEnumerator Walk(string whereToWalk) 
    {
        switch (whereToWalk)
        {
            
            case "left":
                walkTime = 0f;
                startPlayerPosition = transform.position;
                endPlayerPosition = new Vector3
                    (startPlayerPosition.x - 1.75f, transform.position.y, transform.position.z);
                
                while (walkTime < walkDuration)
                {
                    walkTime += Time.deltaTime;
                    transform.position = Vector2.Lerp
                        (startPlayerPosition, endPlayerPosition, walkTime / walkDuration);
                    yield return null;
                }
                break;

            case "right":
                walkTime = 0f;
                break;
        }
    }


}

