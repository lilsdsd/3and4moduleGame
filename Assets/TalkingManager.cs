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
        StartCoroutine(TypeSentence(messageToDisplay));//

        Actor actorToDisplay = currentActors[messageToDisplay.actorId];
        actorName.text = actorToDisplay.name;
        actorImage.sprite = actorToDisplay.sprite;
    }   

    IEnumerator TypeSentence(Message messageToDisplay)//
    {
        messageText.text = "";
        foreach(char letter in messageToDisplay.message.ToCharArray()) {
            yield return new WaitForSeconds(0.07f);
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
