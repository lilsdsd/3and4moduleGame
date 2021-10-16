using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContentLineScript : MonoBehaviour
{

    public GameObject ChangeComic;
    Vector3 JumpPos;
    Vector3 OriginalPos;
    bool isMovingUp;
    public Image img; 
    public bool isActive;
    public GameObject ReadingTracker;
    public Vector3 TrackerOffset;
  //  public bool isLastWord = false;
  //  public GameObject TheBook;
    //public bool isBeforeRead;

    void Start(){
        JumpPos = transform.position + new Vector3(0,5f,0);
        OriginalPos = transform.position;
        isMovingUp = false;
        img = img.GetComponent<Image>();
        //TrackerPos = ReadingTracker.GetComponent<Transform>().position;
    }
    

    //클릭 되는순간 Tween되면서 지정된 컬러로 변경 - 페이지 관리자가 명령시(모든 콘턴츠들이 만져질시) 할당된 오브젝트로 변화

    // 페이지 관리자 오브젝트를 만들어서, 오브젝트들이 전부 ok 상황일시 전부 개별로 public에 지정된 컷씬으로 바뀌는것으로 변경

   public void OnClick() {
       
        if (isMovingUp == false){
            OriginalPos = transform.position;
            JumpPos = transform.position + new Vector3(0,5f,0);
            StartCoroutine(Movement());
            Debug.Log("Cliked.");
            
            isActive = true;
            isMovingUp = true;
            ReadingTracker.gameObject.transform.position = OriginalPos + TrackerOffset;

          //  if(isLastWord == true) {
            //    TheBook.GetComponent<AutoFlip>().FlipRightPage;
            //}
       }
   }

   IEnumerator Movement() {
        LeanTween.move(this.gameObject, JumpPos, 0.25f).setEaseInOutBack();
        //LeanTween.color(this.gameObject, new Color(87/255f,79/255f,65/255f,255/255f), 1f).setDelay(0.2f);
        //img.GetComponent<Image>().color = new Color32(0, 0, 0, 225);
        yield return new WaitForSeconds(0.25f);
         StartCoroutine(MoveBack());
        yield break;
   }

   IEnumerator MoveBack() {
        LeanTween.move(this.gameObject, OriginalPos, 0.25f).setEaseInOutBack();
        yield break;
   }

   public void AutoActive(){
        isActive = true;
        ReadingTracker.gameObject.transform.position = OriginalPos + TrackerOffset;
        
     }
}
