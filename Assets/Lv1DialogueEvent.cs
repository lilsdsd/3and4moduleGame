using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Lv1DialogueEvent : MonoBehaviour
{

    public GameObject dialogueManager; 
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
            Debug.Log("클릭이 감지외었습니다. (eventnum is" + eventNum+" now)" );
            PlusEventNum();
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
                //PlayerDialogueManager.GetComponent<DialogueManager>().DisplayNextSentence();
                
                isClick = true;
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



}
