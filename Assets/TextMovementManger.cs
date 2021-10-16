using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMovementManger : MonoBehaviour
{
    
    //메세지가 발동될시 위로 올라가도록 매니징 
    //터치 할때마다 생성, 스크롤뷰
    //[SerializeField]
    //public GameObject[] textObject;

    public ScrollRect scrollRect;

    public float space = 50f;

    public GameObject textPreFab;

    public List<RectTransform> textObject = new List<RectTransform>();

    void Start(){
        scrollRect = GetComponent<ScrollRect>();
    }

    void Update(){
        
    }

    public void AddNewUIObject() {

        var newUI = Instantiate(textPreFab, scrollRect.content).GetComponent<RectTransform>();
        textObject.Add(newUI);

        float y = 0f;

        for(int i=0; i < textObject.Count; i++)
        {
            textObject[i].anchoredPosition = new Vector2(0f, -y);
            y += textObject[i].sizeDelta.y + space;
        }

        scrollRect.content.sizeDelta = new Vector2(scrollRect.content.sizeDelta.x,y);

    }


}
