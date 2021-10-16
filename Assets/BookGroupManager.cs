using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class BookGroupManager : MonoBehaviour
{
   
    public List<GameObject> Objects = new List<GameObject>();


    int numberOfTrueBooleans = 0;
    public int listLength;

    bool isReturnColor = false;

    void Start(){
        
         listLength = Objects.Count;
    }

    void Update(){
        for (int i = 0; i < listLength; i++) {  

                if( Objects [i].GetComponent<BookShelfBookScript>().isDetected == true && 
                    Objects [i].GetComponent<BookShelfBookScript>().isInteresting == true)
                    {
                        if(Objects [i].GetComponent<BookShelfBookScript>().isInterClicked == true){
                            isReturnColor = true;
                        }
                        
                            
                    }   

                if ( isReturnColor == true){
                    StartCoroutine(Objects [i].GetComponent<BookShelfBookScript>().ReturnToOriginColor());
                    Debug.Log("bakc to origin");
                }
                
               

               
        }
    }
}
