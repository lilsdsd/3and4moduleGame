using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Lv1UpdatingBar : MonoBehaviour
{
    public Image HealthBar;
    public float CurrentHealth;

    
    public List<GameObject> Childs;

    private float MaxHealth = 100f;
    private bool isPlaying = false;

    private void Start(){
        HealthBar = GetComponent<Image>();
        CurrentHealth = 0f;

    }

    void OnEnable(){
        isPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlaying == true){
          //  HealthBar.fillAmount = CurrentHealth / MaxHealth;

         //   CurrentHealth += 7.5f*Time.deltaTime;

            LeanTween.value( gameObject, updateValueExampleCallback, 0f, 100f, 10f).setEase(LeanTweenType.easeInExpo);
                

            isPlaying = false;
        }
        
       void updateValueExampleCallback( float CurrentHealth ){
                Debug.Log("tweened value:"+CurrentHealth+" set this to whatever variable you are tweening...");
                    HealthBar.fillAmount = CurrentHealth / MaxHealth;
                   
                 if (CurrentHealth == 100f){
                    //Destroy( HealthBarGroup );
                    //Debug.Log("healthbarDestroy");
                   // LeanTween.size(UpdatePopUpGroup.GetComponent<RectTransform>(), UpdatePopUpGroup.GetComponent<RectTransform>().sizeDelta*0f, 1f);
                 

                    //LeanTween.size(HealthBarGroup.GetComponent<RectTransform>(), HealthBarGroup.GetComponent<RectTransform>().sizeDelta*0f, 1f);
                     for( int i = 0; i < Childs.Count; i++){

            
                    LeanTween.size(Childs[i].GetComponent<RectTransform>(), Childs[i].GetComponent<RectTransform>().sizeDelta*0f, 0.8f).setEase(LeanTweenType.easeInOutCubic);
             
       
                    }
                 }
               
               
        }

        
    }


}
