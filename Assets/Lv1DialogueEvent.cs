using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Lv1DialogueEvent : MonoBehaviour
{

    public GameObject dialogueManager; 
    public GameObject Screenbutton;
    public bool isClick = true;

    public int eventNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DialogueEvent(){

        switch (eventNum)
        {
            case 0:
                //00씨, 지금 전화 괜찮으신가요?

                dialogueManager.GetComponent<DialogueTrigger>().TriggerDialogue();//
                isClick = true;
            break;
            
            case 1:
            //네 작가님 괜찮습니다. 무슨일이시죠?
                dialogueManager.GetComponent<DialogueManager>().DisplayNextSentence();
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
