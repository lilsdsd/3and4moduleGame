using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lv1FadeOut : MonoBehaviour
{
    //public Image image;
    public CanvasGroup canvas;
    public float a = 1.25f;
    public bool isFadeOK = false;
    // Start is called before the first frame update
    void Start()
    {
        //image = GetComponent<Image>();
        canvas = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
         if ( isFadeOK == true){

         
            //image.color = new Color(image.color.r, image.color.g, image.color.b, a);
            canvas.alpha = a;
            a -= 0.5f * Time.deltaTime;
            if ( a <= 0) {
                isFadeOK = false;
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                 gameObject.SetActive(false);
            }
         } else if( isFadeOK == false){
              gameObject.SetActive(false);
         }
    }

    void Fade(){
        isFadeOK = true;
    }

}
