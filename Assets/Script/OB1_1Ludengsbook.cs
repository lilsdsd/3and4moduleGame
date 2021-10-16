using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OB1_1Ludengsbook : MonoBehaviour
{
    public GameObject theBook;

    private void OnMouseDown() {
        Debug.Log(" GameObject clicked");
       // theBook.SetActive(true);

    }

     void OnTriggerEnter2D(Collider2D other) {
        // if(other.CompareTag("InterObject"))
        if(other.CompareTag("Player")){
            //Debug.Log("interobjct");
            theBook.SetActive(true);
        }
    }

    public void ChangeColorBlue() {
        LeanTween.color(this.gameObject, new Color(87/255f, 90/255f, 121/255f, 255/255f), 2f);
    }

}
