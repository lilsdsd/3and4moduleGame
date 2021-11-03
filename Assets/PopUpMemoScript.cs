using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpMemoScript : MonoBehaviour
{
    public GameObject PopUpMemoGroupObject;
    public GameObject BackButton;
    public List<GameObject> Childs;
    public List<GameObject> ChildsOriginalSize;
    public List<GameObject> Checked;

    public static bool isFirstChecked;
    public static bool isSecondChecked;
    public static bool isThirdChecked;
    void Awake(){   
        LeanTween.size(gameObject.GetComponent<RectTransform>(), gameObject.GetComponent<RectTransform>().sizeDelta*0, 0f );
        gameObject.SetActive(false);
         for( int i = 0; i < Childs.Count; i++){
          
          
            if(ChildsOriginalSize.Count != Childs.Count){
                ChildsOriginalSize.Add( GameObject.Instantiate(Childs[i]) );  
            }
            
            

            LeanTween.size(Childs[i].GetComponent<RectTransform>(), Childs[i].GetComponent<RectTransform>().sizeDelta*0f, 0f).setDelay(0f);
            LeanTween.alphaText(Childs[i].GetComponent<RectTransform>(), 0f, 0f) .setEase(LeanTweenType.easeInCirc);
           LeanTween.alpha(Childs[i].GetComponent<RectTransform>(), 0f, 0f).setDelay(0f);

        }
    }

    void Start(){
        if (isFirstChecked == true){
            Checked[0].SetActive(true);
        }
        if (isSecondChecked == true){
            Checked[1].SetActive(true);
        }
        if (isThirdChecked == true){
            Checked[2].SetActive(true);
        }
      
    }
    void OnEnable()
    {

        LeanTween.size(gameObject.GetComponent<RectTransform>(), gameObject.GetComponent<RectTransform>().sizeDelta*0, 0f );

        LeanTween.size(gameObject.GetComponent<RectTransform>(), PopUpMemoGroupObject.GetComponent<RectTransform>().sizeDelta, 1f).setEase(LeanTweenType.easeInOutBack);

       

        for( int i = 0; i < Childs.Count; i++){

            
             LeanTween.size(Childs[i].GetComponent<RectTransform>(), ChildsOriginalSize[i].GetComponent<RectTransform>().sizeDelta, 0.8f).setEase(LeanTweenType.easeInOutCubic).setDelay(0.8f);
             
             LeanTween.alpha(Childs[i].GetComponent<RectTransform>(), 1f, 1f).setDelay(1f);
             LeanTween.alphaText(Childs[i].GetComponent<RectTransform>(), 1f, 2f) .setEase(LeanTweenType.easeInCirc).setDelay(0.8f);
       
        }
    
    }

    public void BackButtonPressed(){
        LeanTween.size(gameObject.GetComponent<RectTransform>(), gameObject.GetComponent<RectTransform>().sizeDelta*0, 1f );
        //LeanTween.size(BackButton.GetComponent<RectTransform>(), BackButton.GetComponent<RectTransform>().sizeDelta*0, 1f );
        
         for( int i = 0; i < Childs.Count; i++){

            LeanTween.size(Childs[i].GetComponent<RectTransform>(), Childs[i].GetComponent<RectTransform>().sizeDelta*0f, 1f).setDelay(0f);
            LeanTween.alphaText(Childs[i].GetComponent<RectTransform>(), 0f, 1f) .setEase(LeanTweenType.easeInCirc);
           LeanTween.alpha(Childs[i].GetComponent<RectTransform>(), 0f, 1f).setDelay(0f);

        }
        StartCoroutine(AfterBackbutton());
    }

    IEnumerator AfterBackbutton(){
         yield return new WaitForSeconds(1);
         gameObject.SetActive(false);

          /* for( int i = 0; i < Childs.Count; i++){
                Destroy(ChildsOriginalSize[i]);
                
           }

            ChildsOriginalSize.Clear();*/
    }


}
