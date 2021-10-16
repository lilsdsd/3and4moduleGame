using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lv1VideoContentScript : MonoBehaviour
{

   // public SpriteRenderer spriteRenderer;
    public List<Sprite> contentImages;
    int i = 0;
    public GameObject RingingScreen;

    // Start is called before the first frame update
    void Start()
    {
       // spriteRenderer = GetComponent<SpriteRenderer>();
       // spriteRenderer.sprite = contentImages[0];
        gameObject.GetComponent<Image>().sprite = contentImages[0];
    }

    // Update is called once per frame


   // public void ChangeToNextContect()
   public IEnumerator ChangeToNextContect()
    {
     
         if (i == contentImages.Count){
             Debug.Log("Phone ringing!");
             RingingScreen.SetActive(true);
         }else{
            gameObject.GetComponent<Image>().sprite = contentImages[i];
         }
        i++;    
         
        Debug.Log("The i is" + i +"now");
        yield return null;
    }
}
