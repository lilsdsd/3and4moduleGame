using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{

    bool floatup;
    public GameObject player;
    public bool isWalking = false;
    public bool isTimerOn = false;


    void Start(){
        floatup = false;
        isWalking = false;
    }
 void Update(){

    if(isWalking == true){
        if(floatup)
            StartCoroutine( floatingup());
                
            else if(!floatup)
                    StartCoroutine(floatingdown());
    }

    if(isTimerOn == true) { // 외부 버튼으로 인해 작동됩니다.
        isWalking = true;
        StartCoroutine(Timer());
        

    }
     
 }
 IEnumerator floatingup(){
    player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.15f * Time.deltaTime, player.transform.position.z);
    yield return new WaitForSeconds(1);
     floatup = false;
     yield break;
 }
  IEnumerator floatingdown(){
     player.transform.position = new Vector3(player.transform.position.x,player.transform.position.y + (-0.15f * Time.deltaTime), player.transform.position.z);
     yield return new WaitForSeconds(1);
     floatup = true;
        yield break;
 }

    IEnumerator Timer(){
        yield return new WaitForSeconds(5);
         isWalking = false;
    }

}
