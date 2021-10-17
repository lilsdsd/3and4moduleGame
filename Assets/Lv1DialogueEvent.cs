using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Lv1DialogueEvent : MonoBehaviour
{

    public GameObject dialogueManager; 
    public GameObject PlayerDialogueManager; 
    public GameObject Screenbutton;
    public bool isClick = true;

    public int eventNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        DialogueEvent();
    }

    // Update is called once per frame
    

    public void DialogueEvent(){

        switch (eventNum)
        {
            case 0:
                //00씨, 지금 전화 괜찮으신가요?
                Debug.Log("eventNum0Triggered");
                dialogueManager.GetComponent<DialogueTrigger>().TriggerDialogue();//
                isClick = true;
            break;
            
            case 1:
            //네 작가님 괜찮습니다. 무슨일이시죠?
                //PlayerDialogueManager.GetComponent<DialogueManager>().DisplayNextSentence();
                PlayerDialogueManager.GetComponent<DialogueTrigger>().TriggerDialogue();
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
