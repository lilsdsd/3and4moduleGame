using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingBookScript : MonoBehaviour
{
    public GameObject wayPoint;

    public float bookSizeX = 0.35f;
    public float bookSizeY = 0.49f;
    public float bookTweenSizeX = 0.37f;
    public float bookTweenSizeY = 0.52f;

    Vector3 NextPos;
    Vector3 OriginalPos;
    public float MoveTime = 0.25f;
    public float MoveDistance = 0.01f;

     // User Inputs
   // public float degreesPerSecond;
    //public float amplitude;
    //public float frequency;
 
    // Position Storage Variables
   // Vector3 posOffset = new Vector3 ();
    //Vector3 tempPos = new Vector3 ();

    bool isFloating = false;

   // Seeker seeker;


    // Start is called before the first frame update
    void Awake()
    {
       // posOffset = transform.position;
        OriginalPos = transform.position;
        NextPos = transform.position + new Vector3(0,MoveDistance,0);

       // degreesPerSecond = Random.Range(30, 10);
        //amplitude = Random.Range(0.25f, 0.005f);
        //frequency = Random.Range(0.2f, 0.05f);
        
        
    }

   /* void Update(){

        if (isFloating == true) {
        tempPos = posOffset;
        tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
        transform.position = tempPos;

        }
    }*/




   void OnMouseOver(){

        if(isFloating == false){
        StartCoroutine(JumpUp()); //한번 튀어오른 뒤에, 점점 path를 따라 움직인다. 
        isFloating = true;
        wayPoint.GetComponent<wayPointScript>().isFloating = true;

        }
    }

    IEnumerator JumpUp(){
       LeanTween.move(this.gameObject, NextPos, MoveTime).setEaseInOutBack();
        
        
        yield return new WaitForSeconds(MoveTime*2);
        
        yield break;
    } 

    
   
            
   
}
