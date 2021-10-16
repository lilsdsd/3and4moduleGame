using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BubbleGroupManger : MonoBehaviour
{

    public List<GameObject> bubbles ;//= new List<GameObject>();//int들어가야하고
    int numberOfbubbles =0;
    int listLength;
    public GameObject player;
    bool isChecked = false;

    void Start(){
        listLength = bubbles.Count;
    }
    
    //bool[] bubbles;


	//public List<string> names = new List<string> ();//string들어가야하고

	

    void Update(){


    if(numberOfbubbles >= listLength){
       isChecked = true;
       Debug.Log("complete");
       player.GetComponent<level2PLTouchMovement>().bubbleClicked();
       player.GetComponent<Floating>().isTimerOn = true;
       Destroy(gameObject);


    }

        if(isChecked == false){
            for( int cnt = 0; cnt < listLength; cnt++){

                
                if(bubbles[cnt].GetComponent<SmallBubbleClickChecker>().isClicked == true && bubbles[cnt].activeSelf == true) {
                    //for( int i = 0; i < listLength; i++){
                        numberOfbubbles ++;
                        //if(i != cnt)     
                        //bubbles[cnt].GetComponent<SmallBubbleClickChecker>().isClicked = false;
                        
                        bubbles[cnt].SetActive(false);
                        //}
                }

            }
             Debug.Log("bubbleClicked:" +  numberOfbubbles);
        }
       

    }



    

    
    
}
