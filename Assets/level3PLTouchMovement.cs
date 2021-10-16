using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3PLTouchMovement : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite walkingSprite;
    public Sprite nolamSprtie;
    public Sprite phoneLoookingSprite;

    public float playerSpeed = 3f;
    Rigidbody2D body;
    float horizontal;
    float vertical;

    int walkingProsses = 0;
    public float walkingTime = 1.5f;
    public bool isWalking = true;



     void Start()
    {
        body = GetComponent<Rigidbody2D>();        
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * playerSpeed, vertical * playerSpeed );   
        MouseInput();
    }

    void MouseInput(){

        if(Input.GetMouseButtonDown(0)){

            if (isWalking == true){
                walkingProsses++;
                Debug.Log("clicked");
                isWalking = false;
            

                if (walkingProsses == 1) {
                    LeanTween.move(this.gameObject, new Vector3( gameObject.transform.position.x + 6f,gameObject.transform.position.y,gameObject.transform.position.z), 3f).setDelay(0f);
                    LeanTween.move(this.gameObject, new Vector3( gameObject.transform.position.x + 7f,gameObject.transform.position.y,gameObject.transform.position.z), 3f).setDelay(3f);
                    isWalking = false;
                }
                if (walkingProsses == 2) {
                    LeanTween.move(this.gameObject, new Vector3( gameObject.transform.position.x + 4.7f,gameObject.transform.position.y,gameObject.transform.position.z), 3f).setDelay(0f);
                    //LeanTween.move(this.gameObject, new Vector3( gameObject.transform.position.x + 7f,gameObject.transform.position.y,gameObject.transform.position.z), 3f).setDelay(3f);
                    isWalking = false;
                }
            }

        }
        Debug.Log(walkingProsses);

    }

    public void Walking(){
        isWalking = true;
    }

}
