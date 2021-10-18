using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Lv1DialogueEvent : MonoBehaviour
{

    public GameObject dialogueManager; 
    public List<GameObject> Sontecji;
    public bool isClick = true;
    public int eventNum = 0;




    // Start is called before the first frame update
    void Start()
    {
        DialogueEvent();
    }

    // Update is called once per frame
    public void Update(){
        if(isClick == true && Input.GetMouseButtonDown(0)){
            
            PlusEventNum();
            Debug.Log("클릭이 감지외었습니다. (eventnum is" + eventNum+" now)" );
            isClick = false;
            DialogueEvent();
        }else if (isClick == false&& Input.GetMouseButtonDown(0)){
            Debug.Log("클릭이 감지되었으나, isClick이 flase임으로 진행하지 않습니다.");
        }
    }

    public void DialogueEvent(){

        switch (eventNum)
        {
            case 0:
                //00씨, 지금 전화 괜찮으신가요?
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingTrigger>().StartDialogue();

                isClick = true;


            break;
            
            case 1:
                //네 작가님 괜찮습니다. 무슨일이시죠?
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                isClick = true;
            break;

            case 2:
                //대충반영안함
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                isClick = true;
            break;

             case 3:
                //선택지출력
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                // show sontecji
                Sontecji[0].SetActive(true);

                isClick = false;
            break;

            case 4:
                //답변후 메세지 출력 void 선택지 AB가 자동으로 다음 답에 도달하게 해줌 
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                // show sontecji
                

                isClick = false;
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

}
