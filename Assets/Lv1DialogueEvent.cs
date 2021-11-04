using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Lv1DialogueEvent : MonoBehaviour
{

    public GameObject dialogueManager; 
    public GameObject DialogHealthbarGroup;
    public GameObject DialogHealthbar;
    public List<GameObject> Sontecji;
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
            DialogHealthbar.GetComponent<DialogHealthbar>().isCounting = true;
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
                 DialogHealthbarGroup.SetActive(true);
                // 여보세요 작가님?
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingTrigger>().StartDialogue();

               // isClick = true;
                StartCoroutine(ClickDelay(3));

            break;
            
            case 1:
                //지금 통화 괜찮은가?
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                 StartCoroutine(ClickDelay(3));
                //isClick = true;
            break;

            case 2:
                //어 네 괜찮습니다. 무슨일이시죠?
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                 StartCoroutine(ClickDelay(3));
                //isClick = true;
            break;

             case 3:
                //그.. 소설중에 어린아이에 대한 묘사를 하고싶은데
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                // show sontecji
                 StartCoroutine(ClickDelay(3));
              //  Sontecji[0].SetActive(true);
                
                //isClick = false;
            break;

            case 4:
                //요즘 아이들은 도통 모르겠어.
               // dialogueManager.GetComponent<TalkingManager>().activeMessage = 7;
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                 StartCoroutine(ClickDelay(3));
                 //isClick = true;
            break;

            case 5:
                //새로운 책이 필요하신 거군요
                
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                 StartCoroutine(ClickDelay(3));
                 //isClick = true;
            break;

            case 6:
                //맞아.
                
                Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                 StartCoroutine(ClickDelay(3));
                 //isClick = true;
                 //전화 이벤트가 종료되며 메인화면으로 이동
                 
            break;

            case 7: 
                  Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                 StartCoroutine(ClickDelay(3));

            break;

            case 8: 
                  Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                 StartCoroutine(ClickDelay(3));

            break;

            case 9: 
                  Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                 StartCoroutine(ClickDelay(3));

            break;

            case 10: 
                  Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                 StartCoroutine(ClickDelay(3));

            break;

            case 11: 
                  Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                 StartCoroutine(ClickDelay(3));

            break;
            

            case 12: 
                  Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                 StartCoroutine(ClickDelay(3));

            break;   

            case 13: 
                  Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                 StartCoroutine(ClickDelay(3));

            break;

            case 14: 
                  Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                 StartCoroutine(ClickDelay(3));

            break;

            case 15: 
                  Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                 StartCoroutine(ClickDelay(3));

            break;
            

            case 16: 
                  Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                 StartCoroutine(ClickDelay(3));

            break;   

            case 17: 
                  Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                 StartCoroutine(ClickDelay(3));

            break;

        case 18: 
                  Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                 StartCoroutine(ClickDelay(3));

            break;

            case 19: 
                  Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                 StartCoroutine(ClickDelay(3));

            break;
            

            case 20: 
                  Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                 StartCoroutine(ClickDelay(3));

            break;   

            case 21: 
                  Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                 StartCoroutine(ClickDelay(3));

            break;

            case 22: 
                  Debug.Log("eventNum" + eventNum +"Triggered");
                dialogueManager.GetComponent<TalkingManager>().NextMessage();
                
                
                 StartCoroutine(ClickDelay(3));

            break;

            case 23: 
                  SceneManager.LoadScene("Lv1MainScreen");

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
         DialogHealthbar.GetComponent<DialogHealthbar>().isCounting = false;
         isClick = true;
         yield break;
    }

}
