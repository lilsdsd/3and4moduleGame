using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookBoriBookImageChanger : MonoBehaviour
{
    public List<Sprite> BookImageList;
    public GameObject BookImageObject;
    public int BookCodesNumber;
    // Start is called before the first frame update

    // Update is called once per frame
    public void FirstImage(){
        if (BookImageList.Count >= 1){
            BookImageObject.GetComponent<Image>().sprite = BookImageList[0];
            BookCodesNumber = 1;
        }else{
            Debug.Log("해당 버튼의 경우의 수까지 지정된 책이 없습니다!!");
        }
        
    }
    public void SecondImage(){
         if (BookImageList.Count >= 2){
            BookImageObject.GetComponent<Image>().sprite = BookImageList[1];
            BookCodesNumber = 2;
        }else{
            Debug.Log("해당 버튼의 경우의 수까지 지정된 책이 없습니다!!");
        }
    }
    public void ThirdImage(){
         if (BookImageList.Count >= 3){
            BookImageObject.GetComponent<Image>().sprite = BookImageList[2];
            BookCodesNumber = 3;
        }else{
            Debug.Log("해당 버튼의 경우의 수까지 지정된 책이 없습니다!!");
        }
    }
    public void ForthImage(){
         if (BookImageList.Count >= 4){
            BookCodesNumber = 4;
            BookImageObject.GetComponent<Image>().sprite = BookImageList[3];
        }else{
            Debug.Log("해당 버튼의 경우의 수까지 지정된 책이 없습니다!!");
        }
    }

      public void FifthImage(){
         if (BookImageList.Count >= 5){
            BookImageObject.GetComponent<Image>().sprite = BookImageList[4];
            BookCodesNumber = 5;
        }else{
            Debug.Log("해당 버튼의 경우의 수까지 지정된 책이 없습니다!!");
        }
    }
      public void SixImage(){
         if (BookImageList.Count >= 6){
             BookCodesNumber = 6;
            BookImageObject.GetComponent<Image>().sprite = BookImageList[5];
        }else{
            Debug.Log("해당 버튼의 경우의 수까지 지정된 책이 없습니다!!");
        }
    }
}
