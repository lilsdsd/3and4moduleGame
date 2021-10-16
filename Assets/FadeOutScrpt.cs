using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOutScrpt : MonoBehaviour
{
     public Image image;
    private float a;

     void Start () 
    {
         image = GetComponent<Image>();
        
    }
    // Start is called before the first frame update
    void Update()
    {
        // Debug.Log(a);
       // gameObject.LeanAlpha(1f,3f);
          image.color = new Color(image.color.r, image.color.g, image.color.b, a);
          a += 0.15f *Time.deltaTime;
          if ( a >= 1) {
               
               SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
          }
    }
}
