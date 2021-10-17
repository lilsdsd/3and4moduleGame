using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PlayerDialogueTrigger : MonoBehaviour
{
    
    public Dialogue PlayerDialogue;

    public void PlayerTriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(PlayerDialogue); 
    }

    
}
