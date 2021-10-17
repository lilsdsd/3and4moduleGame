using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lv1RingingScreenScript : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform originalSize;
    public List<GameObject> Childs;
    public List<GameObject> ChildsOriginalSize ;
    void Awake(){
       gameObject.SetActive(false);
        //transform.SetAsFirstSibling();
        LeanTween.size(gameObject.GetComponent<RectTransform>(), gameObject.GetComponent<RectTransform>().sizeDelta*0f, 0f).setDelay(0f);
        
        for( int i = 0; i < Childs.Count; i++){
            //List<RectTransform> ChildsOriginalSize = new List <RectTransform>();
           // ChildsOriginalSize[i] = Childs[i].GetComponent<RectTransform>();
            
            ChildsOriginalSize.Add( GameObject.Instantiate(Childs[i]) );  //Childs[i].GetComponent<RectTransform>());
            

            LeanTween.size(Childs[i].GetComponent<RectTransform>(), Childs[i].GetComponent<RectTransform>().sizeDelta*0f, 0f).setDelay(0f);
           // LeanTween.alpha(Childs[i].GetComponent<RectTransform>(), 0f, 0f).setDelay(0f);

        }

       // CheckForChanges();
        
    }
    void OnEnable()
    {
      
        //transform.SetAsLastSibling();
        Debug.Log("RingingScreenObject Active Succeseful.");
        
  
        LeanTween.size(gameObject.GetComponent<RectTransform>(), originalSize.sizeDelta, 0.8f).setEase(LeanTweenType.easeInOutCubic);

        for( int i = 0; i < Childs.Count; i++){

            
             LeanTween.size(Childs[i].GetComponent<RectTransform>(), ChildsOriginalSize[i].GetComponent<RectTransform>().sizeDelta, 0.8f).setEase(LeanTweenType.easeInOutCubic).setDelay(0.8f);
             //LeanTween.alpha(Childs[i].GetComponent<RectTransform>(), 1f, 0f).setDelay(0.7f);
       
        }

        
           
      //  CheckForChanges();
    }

    /*public void CheckForChanges() {
        RectTransform children = transform.GetComponentInChildren<RectTransform>();

        float min_x, max_x, min_y, max_y;
        min_x = max_x = transform.localPosition.x;
        min_y = max_y = transform.localPosition.y;

        foreach (RectTransform child in children) {
            Vector2 scale = child.sizeDelta;
            float temp_min_x, temp_max_x, temp_min_y, temp_max_y;

            temp_min_x = child.localPosition.x - (scale.x / 2);
            temp_max_x = child.localPosition.x + (scale.x / 2);
            temp_min_y = child.localPosition.y - (scale.y / 2);
            temp_max_y = child.localPosition.y + (scale.y / 2);

            if (temp_min_x < min_x)
                min_x = temp_min_x;
            if (temp_max_x > max_x)
                max_x = temp_max_x;

            if (temp_min_y < min_y)
                min_y = temp_min_y;
            if (temp_max_y > max_y)
                max_y = temp_max_y;
        }

        GetComponent<RectTransform>().sizeDelta = new Vector2(max_x - min_x, max_y - min_y);
    }*/
}
