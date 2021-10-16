using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookColorChanger : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite graySprite;
    public Sprite originalSprite;
    private float detectingDistance = 4f;
    //Detecting Player
    private Transform playerPosition;
    // Start is called before the first frame update
    void Start()
    {
      spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        DetectingPlayer();
    }

     public void DetectingPlayer(){
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerPosition = player.transform;
        float distance = Vector3.Distance(playerPosition.position, transform.position);
       

        if (distance <= detectingDistance) {
            Debug.Log("ㅇㅔ에에엥ㅇ!!");   
            spriteRenderer.sprite = graySprite;

        }else{
                spriteRenderer.sprite = originalSprite;
        }
    }






}
