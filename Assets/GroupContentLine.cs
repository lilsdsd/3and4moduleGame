using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class GroupContentLine : MonoBehaviour
{
    public GameObject contentObj;
    //public int number =5;
    public List<GameObject> Objects = new List<GameObject>();
    public int listLength;
    public Color BeforeReadColor;
    public Color ReadedColor;

    void Start(){
        Objects.Add(contentObj);
        listLength = Objects.Count;
    }

    void Update(){

        int numberOfTrueBooleans = 0;
        
            for (int i = 0; i < listLength; i++) {  

                if(numberOfTrueBooleans < listLength && Objects [numberOfTrueBooleans].GetComponent<ContentLineScript>().isActive == false){

                    Objects [numberOfTrueBooleans].GetComponent<Image>().color = BeforeReadColor;//new Color32(255, 0, 0, 225);
               } else if (Objects [numberOfTrueBooleans].GetComponent<ContentLineScript>().isActive == true){
                   Objects [numberOfTrueBooleans].GetComponent<Image>().color = ReadedColor;
               }

               if ( Objects [i].GetComponent<ContentLineScript>().isActive == true) {
                    numberOfTrueBooleans++; 
                    Debug.Log("Object: " + numberOfTrueBooleans + "has been active");
                    
               }
               
            }
     

    }
    

}
