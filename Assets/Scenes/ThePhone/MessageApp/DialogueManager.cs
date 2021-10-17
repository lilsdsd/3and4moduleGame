using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DialogueManager : MonoBehaviour
{

    public Text nameText;    
    public Text dialogueText;

   // public Text PlayerDialogueText; // p

    public GameObject dialogueManager; 

    private Queue<string> sentences;

  //  private Queue<string> PlayerSentences; // p

    public bool isOtherSpeak = true; // true일때 other false일때 player

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        //PlayerSentences = new Queue<string>();
        
    }

    public void StartDialogue (Dialogue dialogue){
      // Debug.Log("Starting converstation with" + dialogue.name);
        if(isOtherSpeak == true){
            nameText.text = dialogue.name;

            sentences.Clear();

            foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
        }else{

            Debug.Log("Event order error - other - Speak");
        }
       
        

    }

    public void DisplayNextSentence ()
    {

        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        //dialogueText.text = sentence;
        StartCoroutine(TypeSentence(sentence));
       // Debug.Log(sentence);

    }


    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray()){
            yield return new WaitForSeconds(0.07f);
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        Debug.Log("End of converstation");
    }


/*
//////////////////

   public void StartPlayerDialogue (Dialogue playerdialogue){
      // Debug.Log("Starting converstation with" + dialogue.name);
        if(isOtherSpeak == false){
            

            PlayerSentences.Clear();

            foreach (string PlayerSentence in playerdialogue.PlayerSentences)
        {
            PlayerSentences.Enqueue(PlayerSentence);
        }

        DisplayPlayerNextSentence();
        }else{

            Debug.Log("Event order error - playerSpeak");
        }
       
        

    }

    public void DisplayPlayerNextSentence ()
    {

        if (PlayerSentences.Count == 0)
        {
            PlayerEndDialogue();
            return;
        }

        string PlayerSentence = PlayerSentences.Dequeue();
        StopAllCoroutines();
        //dialogueText.text = sentence;
        StartCoroutine(TypeSentence(PlayerSentence));
       // Debug.Log(sentence);

    }


    IEnumerator PlayerTypeSentence(string PlayerSentence)
    {
        PlayerDialogueText.text = "";
        foreach (char letter in PlayerSentence.ToCharArray()){
            yield return new WaitForSeconds(0.07f);
            PlayerDialogueText.text += letter;
            yield return null;
        }
    }

    void PlayerEndDialogue()
    {
        Debug.Log("End of converstation");
    }



*/
    
}
