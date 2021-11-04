using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

   public float ShakeAmount;

   float ShakeTime;
   Vector3 initialPosition;
   public bool isCalling;
   public bool isMetro;

   public void VibrateForTime(float time)
   {
       ShakeTime = time;
   }
    private void Start(){
        initialPosition = new Vector3(0f, 0f, -5f);
       // VibrateForTime(10f);
       if (isCalling == true){
           StartCoroutine(Ringing());
       }
    }

   private void Update() {
    if( isCalling == true){
        
       if (ShakeTime > 0) 
       {
           transform.position = Random.insideUnitSphere * ShakeAmount + initialPosition;
           ShakeTime -= Time.deltaTime;
       }
       else{
           ShakeTime = 0.0f;
           transform.position = initialPosition;
       }
    }else if( isMetro == true){

    }


   }


    public IEnumerator Ringing() {
        VibrateForTime(0.8f);
          yield return new WaitForSeconds(1);
          StartCoroutine(Ringing());
        yield break;
    }

}

