using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv1UpdatingBar : MonoBehaviour
{
    public Image HealthBar;
    public float CurrentHealth;

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
            HealthBar.fillAmount = CurrentHealth / MaxHealth;

            CurrentHealth += 1*Time.deltaTime;
        }
       
    }
}
