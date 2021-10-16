using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class level1TransTextScript : MonoBehaviour
{

    TextMeshProUGUI textMeshProUGUI;
    // Start is called before the first frame update
   private void OnEnable()
    {

       //textMeshProUGUI.color = new Color32(255,255,255,255);
      //LeanTween.alpha(this.gameObject, 0, 0);
      //LeanTween.alpha(this.gameObject, 1, 2.5f);
      this.gameObject.transform.localPosition = new Vector2(500, 0); // 대각선 
      this.gameObject.LeanMoveLocalX(-212, 3.5f).setEaseInOutBack().delay = 1;
      this.gameObject.LeanMoveLocalX(-Screen.width, 3.5f).setEaseInOutBack().delay = 6.25f;
       // this.LeanAlpha(0, 1.5f);
        
       //transform.localPosition = new Vector2(250, 0); 
       //transform.LeanMoveLocalX(0, 0.5f).setEaseOutBack().delay = 3.5f;
       
      // ClosePopup();
       // StartCoroutine(Wait(2.5f));
        
    }

    

    public void ClosePopup()
    {
    
      //  transform.LeanMoveLocalX(-Screen.height, 1f).setEaseInExpo().setOnComplete(OnComplete);
    }

    public IEnumerator Wait(float delayInSecs)
    {
         yield return new WaitForSeconds(delayInSecs);
         StartCoroutine(TextUp());
    }

    IEnumerator TextUp() {
       
       
         textMeshProUGUI.color = new Color32(255,255,255,255);
        yield return new WaitForSeconds(6); 
        
    }

    void OnComplete()
    {
       
        gameObject.SetActive(false);
    }

}
