using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wayPointScript : MonoBehaviour
{
    public Transform theBook;

    Vector3 posOffset = new Vector3 ();
    Vector3 tempPos = new Vector3 ();

    private float degreesPerSecond;
    private  float amplitude;
    private float frequency;
    public bool isFloating;

    //public bool isFloating;
    // Start is called before the first frame update
    void Awake()
    {
        posOffset = transform.position;
        this.gameObject.transform.position = theBook.transform.position;
        degreesPerSecond = Random.Range(60, 20);
        amplitude = Random.Range(0.5f, 2.5f);
        frequency = Random.Range(0.05f, 0.1f);
        isFloating = false;
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false; 
    }

    void Update(){

        if (isFloating == true) {
        tempPos = posOffset;
        tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
        transform.position = tempPos;

        }
    }

    
}
