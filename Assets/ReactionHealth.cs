using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactionHealth : MonoBehaviour
{
    public Image HealthBar;
    public float CurrentHealth;
    public float num ;

    private float MaxHealth = 100f;

    private bool isPlaying = false;

   // public GameObject imgA;//5
   //  public GameObject imgB;//12
     // public GameObject imgC;//85
      // public GameObject imgD;//100

    public List<Image> img;
    //public List<Color> col;
    Color colA;
    Color colB;
    Color colC;
    // Start is called before the first frame update
    void Start()
    {
        HealthBar = GetComponent<Image>();

        Color colA = new Color(216, 158, 71,1);
        Color colB = new Color(62, 197, 0,1);
        Color colC = new Color(248, 55, 78,1);

        CurrentHealth = 0f;
    }

     private void Update() {
        
        
        if (isPlaying == true){
           // CurrentHealth += num*Time.deltaTime;
           
            LeanTween.value( gameObject, CurrentHealth, MaxHealth, 5f).setEase(LeanTweenType.easeInOutExpo).setOnUpdate( (float val)=>{ 
                //Debug.Log("tweened val:"+val);
                CurrentHealth = val;
                HealthBar.fillAmount = CurrentHealth / MaxHealth;
                Debug.Log(Mathf.RoundToInt(CurrentHealth));

            } );
            
            switch(CurrentHealth){
                case 0:  
                LeanTween.value( HealthBar.color, colA,  colA, 5f).setOnUpdate( (Color val)=>{ 
                    Debug.Log("tweened val:"+val);
                    HealthBar.color = val;
                } );

                break;

                case 5:  
                LeanTween.value( HealthBar.color,  colA,  colB, 5f).setOnUpdate( (Color val)=>{ 
                    Debug.Log("tweened val:"+val);
                    HealthBar.color = val;
                } );

                break;

                case 85:  
                LeanTween.value( HealthBar.color,  colB, colC, 5f).setOnUpdate( (Color val)=>{ 
                    Debug.Log("tweened val:"+val);
                    HealthBar.color = val;
                } );

                break;
            }
            
            
         }




     }

    public void Play(){
        isPlaying = true;
        Debug.Log("isPlaying is true");
    }

    
}
