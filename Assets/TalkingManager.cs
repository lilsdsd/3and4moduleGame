using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkingManager : MonoBehaviour
{
   public Image actorImage;
    public Text actorName;
    public Text messageText;
    public RectTransform backgroundBox;
    public GameObject BG;

    public float textWritingDelaySpeed;

    
    Message[] currentMessages;
    Actor[] currentActors;
    int activeMessage = 0;

    public static bool isActive = false;

    public void OpenDialogue(Message[] messages, Actor[] actors){
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0;
        isActive = true;

        Debug.Log(" Started conversation! Loaded messages " + messages.Length);
        DisplayMessage();
    }
    
    void DisplayMessage() {
        Message messageToDisplay = currentMessages[activeMessage];
       
        //messageText.text = messageToDisplay.message;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(messageToDisplay));//

        Actor actorToDisplay = currentActors[messageToDisplay.actorId];
       
         actorName.text = actorToDisplay.name;
        switch(actorName.text)
        {
            case "작가":
                Debug.Log("화자가 작가임으로 텍스트 박스를 파란색으로 변경합니다.");
                  LeanTween.color(BG.GetComponent<RectTransform>(), new Color(77/255f,228/255f, 110/255f,255/255f), 0.5f).setEase(LeanTweenType.easeInCubic);
            break;

            case "편집장":
                Debug.Log("화자가 편집장임으로 텍스트 박스를 노란색으로 변경합니다.");
                LeanTween.color(BG.GetComponent<RectTransform>(), new Color(254/255f,236/255f, 141/255f,255/255f), 0.5f).setEase(LeanTweenType.easeInCubic);//new Color(254/255f,236/255f, 141/255f,255/255f)
            break;

            default:
                Debug.Log("알수없는 화자, 혹은 경우에 수를 설정하지 않은 인물이 감지되었습니다");
            break;


            
        }
        

       

        actorImage.sprite = actorToDisplay.sprite;
    }   

    IEnumerator TypeSentence(Message messageToDisplay)//
    {
        messageText.text = "";
        foreach(char letter in messageToDisplay.message.ToCharArray()) {
            yield return new WaitForSeconds(textWritingDelaySpeed);
            messageText.text += letter;
            yield return null;
        }
    }





    public void NextMessage() {
        activeMessage++;
        if (activeMessage < currentMessages.Length){
            DisplayMessage();
        }else {
            Debug.Log("Convertastion ended");
            isActive = false;
        }
    }


    public void Update(){
        if (Input.GetKeyDown(KeyCode.Space) && isActive == true) {
            NextMessage();
        }
    }

}
