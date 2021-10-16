using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveConMovement : MonoBehaviour
{

    public Joystick joystick;
    public float runSpeed = 10f;
    Rigidbody2D rb;
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
        rb.velocity = new Vector2(joystick.Horizontal * runSpeed, joystick.Vertical * runSpeed);   
    }
       
    
}
