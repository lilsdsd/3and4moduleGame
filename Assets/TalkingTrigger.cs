using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingTrigger : MonoBehaviour
{

    private void Start(){
        StartDialogue();
    }
    public Message[] messages;
    public Actor[] actors;

    public void StartDialogue() {
        FindObjectOfType<TalkingManager>().OpenDialogue(messages, actors);
    }


}

[System.Serializable]
public class Message {
    public int actorId;
    public string messae;
}

[System.Serializable]

public class Actor {
    public string name;
    public Sprite sprite;
}

