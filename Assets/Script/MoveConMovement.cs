/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveConMovement : MonoBehaviour
{

    public Joystick joystick;
    public float runSpeed = 2f;
    Rigidbody2D rb;
    public bool isOnlyHorizontal;
    public bool isOnlyVertical;

    //Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        //direction = joystick.Direction;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isOnlyHorizontal == false && isOnlyVertical == false){
            rb.velocity = new Vector2(joystick.Horizontal * runSpeed, joystick.Vertical * runSpeed); 
        }
        else if ( isOnlyHorizontal == true & isOnlyVertical == false){
            rb.velocity = new Vector2(joystick.Horizontal * runSpeed, 0); 
        }else if( isOnlyHorizontal == false & isOnlyVertical == true ) {
            rb.velocity = new Vector2(0, joystick.Vertical* runSpeed); 
        }else{
            Debug.Log("Error! check isOnlyHorizontal and isOnlyVertical are both checked. (or code)");
        }

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
           isOnlyHorizontal = false;
           isOnlyVertical = false;
           // - 트리거 태크에 닿으면 조작이 바뀌도록 해보자
        }
    }
       
    
}*/
