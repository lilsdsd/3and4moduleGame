using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewController : MonoBehaviour
{

    public ScrollRect scrollRect;

    public float space = 50f;

    public GameObject uiPrefab;
    public GameObject uiPrefabChildText; 
    public GameObject uiPrefab2;
     GameObject uiPrefab2ChildText;  

    public List<RectTransform> uiObjects = new List<RectTransform>();
    public List<RectTransform> uiObjects2 = new List<RectTransform>();
    void Start()
    {
        scrollRect = GetComponent<ScrollRect>();   

         uiPrefabChildText = uiPrefab.transform.GetChild(1).gameObject;
        uiPrefab2ChildText = transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddOtherUIObject() {

        var newUi = Instantiate(uiPrefab, scrollRect.content).GetComponent<RectTransform>();
        uiObjects.Add(newUi);
        
        float y = 0f;

       for(int i = 0; i < uiObjects.Count; i++){
        
            uiObjects[i].anchoredPosition = new Vector2(0f, -y);
            //uiObjects[i].anchoredPosition = new Vector2(0f, y);
            
        
            y += uiObjects[i].sizeDelta.y + space;

            if(i == 0){
                uiObjects[0].gameObject.SetActive(false);
               // AddOtherUIObject();
            }

           // #region // 대사스크립트

                switch(i){

                    case 0: 

                     uiPrefabChildText.GetComponent<Text>().text = "aaaaaa";
                    
                     break;

                     case 1:

                     uiPrefabChildText.GetComponent<Text>().text = "bbbbb";

                     break;

                     
                     case 2:

                     uiPrefabChildText.GetComponent<Text>().text = "cccc";

                     break;

                     case 3:

                     uiPrefabChildText.GetComponent<Text>().text = "dddd";

                     break;

                     case 4:

                     uiPrefabChildText.GetComponent<Text>().text = "eeee";
                     

                     break;

                     default:

                        uiPrefabChildText.GetComponent<Text>().text = "default";

                     break;


                }

               // uiPrefabChildText.GetComponent<Text>().text = "This is my text";
           // #endregion

                Debug.Log(i);
        }
        
        scrollRect.content.sizeDelta = new Vector2(scrollRect.content.sizeDelta.x,y);


        



    }

    public void AddNMyUIObject() {

        var newUi2 = Instantiate(uiPrefab2, scrollRect.content).GetComponent<RectTransform>();
        uiObjects2.Add(newUi2);
        
        float y = 0f;

       for(int i = 0; i < uiObjects2.Count; i++){
            uiObjects2[i].anchoredPosition = new Vector2(0f, -y);
            //uiObjects[i].anchoredPosition = new Vector2(0f, y);
            
        
            y += uiObjects2[i].sizeDelta.y + space;

        }

        scrollRect.content.sizeDelta = new Vector2(scrollRect.content.sizeDelta.x,y);
    }


}


