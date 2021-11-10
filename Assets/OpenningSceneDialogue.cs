using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class OpenningSceneDialogue: MonoBehaviour
{

    public GameObject dialogueManager; 
    public GameObject BookCrossingIntroObj;
   // public GameObject DialogHealthbarGroup;
    //public GameObject DialogHealthbar;
    public GameObject CountinueInstraction;

    public bool isClick = true;
    public int eventNum = 0;




    // Start is called before the first frame update
    void Start()
    {
        DialogueEvent();
        //DialogHealthbarGroup.SetActive(false);
    }

    // Update is called once per frame
    public void Update(){
        if(isClick == true && Input.GetMouseButtonDown(0)){
            
            PlusEventNum();
            Debug.Log("클릭이 감지외었습니다. (eventnum is" + eventNum+" now)" );
            isClick = false;
            CountinueInstraction.SetActive(false);
            //DialogHealthbar.GetComponent<DialogHealthbar>().isCounting = true;
            DialogueEvent();
        }else if (isClick == false&& Input.GetMouseButtonDown(0)){
            Debug.Log("클릭이 감지되었으나, isClick이 flase임으로 진행하지 않습니다.");
        }

      //if(isClick == false){
         //  DialogHealthbar.GetComponent<DialogHealthbar>().isCounting = false;
       // }
    }

    public void DialogueEvent(){

        switch (eventNum)
        {
            case 0:
             //    DialogHealthbarGroup.SetActive(true);
                // 여보세요 작가님?
                
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingTrigger>().StartDialogue();

                //isClick = true;
               StartCoroutine(ClickDelay(3));

            break;
            
            case 1:
                //지금 통화 괜찮은가?
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                BookCrossingIntroObj.SetActive(false);
                 StartCoroutine(ClickDelay(3));
               // isClick = true;
            break;

            case 2:
                //지금 통화 괜찮은가?
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                 StartCoroutine(ClickDelay(3));
               // isClick = true;
            break;

            case 3:
                //지금 통화 괜찮은가?
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                 StartCoroutine(ClickDelay(3));
                //isClick = true;
            break;

            case 4:
                //지금 통화 괜찮은가?
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                 StartCoroutine(ClickDelay(3));
                //isClick = true;
            break;

            case 5:
                //지금 통화 괜찮은가?
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                 StartCoroutine(ClickDelay(3));
                //isClick = true;
            break;

            case 6:
                
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                BookCrossingIntroObj.SetActive(true);
                 StartCoroutine(ClickDelay(3));
                //isClick = true;
            break;

            case 7:
                
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                BookCrossingIntroObj.GetComponent<BookCrossingIntro>().AImg();
                StartCoroutine(ClickDelay(3));
                //isClick = true;
            break;


            case 8:
                
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
               BookCrossingIntroObj.GetComponent<BookCrossingIntro>().BImg();
                StartCoroutine(ClickDelay(3));
                //isClick = true;
            break;

            case 9:
                
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
               
                StartCoroutine(ClickDelay(3));
                //isClick = true;
            break;

            case 10:
                
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
               BookCrossingIntroObj.GetComponent<BookCrossingIntro>().AImgDown();
               BookCrossingIntroObj.GetComponent<BookCrossingIntro>().BImgDown();
               BookCrossingIntroObj.GetComponent<BookCrossingIntro>().CImg();
               
                StartCoroutine(ClickDelay(3));
                //isClick = true;
            break;
            default:
           

            break;
        }

    }

    public void PlusEventNum(){
        if (isClick == true){
            eventNum++;
        }
    }

    public void SontecjiAActive(){

        dialogueManager.GetComponent<TalkingManager>().activeMessage += 0;
        dialogueManager.GetComponent<TalkingManager>().NextMessage();
        dialogueManager.GetComponent<TalkingManager>().activeMessage += 1;
        isClick = true;
    }

    public void SontecjiBActive(){

        dialogueManager.GetComponent<TalkingManager>().activeMessage += 1;
        dialogueManager.GetComponent<TalkingManager>().NextMessage();
        dialogueManager.GetComponent<TalkingManager>().activeMessage += 1;
        isClick = true;
    }
    public IEnumerator ClickDelay(float sec){

        isClick = false;
        Debug.Log("클릭딜레이를" + sec+ "초간 실행합니다");
        yield return new WaitForSeconds(sec);
        CountinueInstraction.SetActive(true);
       //  DialogHealthbar.GetComponent<DialogHealthbar>().isCounting = false;
         isClick = true;
         yield break;
    }

}
