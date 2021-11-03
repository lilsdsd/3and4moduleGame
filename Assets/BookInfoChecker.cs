using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookInfoChecker : MonoBehaviour
{
    public GameObject BookImage;
    public GameObject TitleSectionText;
    public GameObject WriterSectionText;
    public GameObject PublicherSectionText;
    public GameObject CateGoriSectionText;
    public GameObject OKButton;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BookImage.GetComponent<BookBoriBookImageChanger>().BookCodesNumber > 0){
            OKButton.GetComponent<Image>().color = new Color32(73, 167, 221, 255);
            OKButton.GetComponent<Button>().interactable = true;
      }
        
        if (BookImage.GetComponent<BookBoriBookImageChanger>().BookCodesNumber == 0 ){
            TitleSectionText.GetComponent<Text>().text = "";
            WriterSectionText.GetComponent<Text>().text = "";
            PublicherSectionText.GetComponent<Text>().text = "";
            CateGoriSectionText.GetComponent<Text>().text= "";
            OKButton.GetComponent<Image>().color = new Color32(118, 118, 118, 255);
            OKButton.GetComponent<Button>().interactable = false;
        }
        if (BookImage.GetComponent<BookBoriBookImageChanger>().BookCodesNumber == 1 ){
            TitleSectionText.GetComponent<Text>().text = "어쌔신크리드";
            WriterSectionText.GetComponent<Text>().text = "올리버 보든";
            PublicherSectionText.GetComponent<Text>().text = "제우 미디어";
            CateGoriSectionText.GetComponent<Text>().text= "소설";
        }
        if (BookImage.GetComponent<BookBoriBookImageChanger>().BookCodesNumber == 2 ){
            TitleSectionText.GetComponent<Text>().text = "지브리의 천재들";
            WriterSectionText.GetComponent<Text>().text = "스즈키 도시오";
            PublicherSectionText.GetComponent<Text>().text = "출판출판사";
            CateGoriSectionText.GetComponent<Text>().text= "다큐멘터리";
        }
 

    }
}
