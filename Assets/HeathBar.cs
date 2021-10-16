using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeathBar : MonoBehaviour
{
    public Image HealthBar;
    public float CurrentHealth;

    private float MaxHealth = 100f;

    private bool isPlaying = false;

    private void Start(){
        HealthBar = GetComponent<Image>();
        CurrentHealth = 0f;

    }

    private void Update() {
        HealthBar.fillAmount = CurrentHealth / MaxHealth;
        if (isPlaying == true){
            CurrentHealth += 1*Time.deltaTime;
        }
        
    }

    public void Play(){
        isPlaying = true;
    }

    

}
