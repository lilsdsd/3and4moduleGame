using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{

    public GameObject block;
    
    //public Text txt;

    public float x1;
    public float x2;
    public float Speed = 2f;
    public float deccel = 0.1f;
    public bool facingRight;

    //public Animator anim; 
    public GameObject Player;  
    public Animator Animation;
     

    public int move = 0; 

    public int movemode = 0; //가벼움단계 

    // Start is called before the first frame update
    void Start()
    {
     //anim = GetComponent<Animator>();   
        facingRight = false;
        Animation = Player.GetComponent<Animator>();
    }

    private void Flip()
        {
                // Switch the way the player is labelled as facing
                //facingRight = !facingRight;
            if (move == 1) {
                Vector3 theScale = Player.transform.localScale;
                if (theScale.x < 0) {
                    
                    theScale.x *= -1;
                    //theScale = 1;
                    Player.transform.localScale = theScale;
                }
            }

            if (move == 2) {
                Vector3 theScale = Player.transform.localScale;
                if (theScale.x > 0) {
                   
                    theScale.x *= -1;
                    //theScale = 1;
                    Player.transform.localScale = theScale;
                }
            }
        }

    void FixedUpdate () {
        
    }
    // Update is called once per frame
    void Update()
    {
       
        #region // - input system
            

            if (Input.GetMouseButtonDown(0)) {
            //if (Input.GetTouch(0).phase == TouchPhase.Began) {//모바일 테스트용 
            
                x1 = Input.mousePosition.x;
            }

            if (Input.GetMouseButtonUp(0)) {
            
            //if (Input.GetTouch(0).phase == TouchPhase.Ended) { //모바일 테스트용 
            
                x2 = Input.mousePosition.x;

                if(x1 > x2) {

                //txt.text = "Move Left";
                    move = 1;

                }

                if (x2 > x1) {

                //txt.text  = "Move Right";   
                    move = 2;

                }
            }

        #endregion 

        #region // deccel to cicle

           if (movemode == 0) { //무거운 움직임 
                if (Speed == 0 || Speed < 0) {
                    move = 0;
                    Speed = 2f;
                    deccel = 0.025f;
                }
           }

            if (movemode == 1) { //가벼움 1단계 
                if (Speed == 0 || Speed < 0) {
                    move = 0;
                    Speed = 3f;
                    deccel = 0.05f;
                }
           }

            if (movemode == 2) { // 가벼움 2단계
                if (Speed == 0 || Speed < 0) {
                    move = 0;
                    Speed = 3.5f;
                    deccel = 0.045f;
                }
           }

             if (movemode == 3) { // 가벼움 3 단계
                if (Speed == 0 || Speed < 0) {
                    move = 0;
                    Speed = 3.5f;
                    deccel = 0.045f;
                }
           }
        #endregion

        #region // - movement

                if (move == 1) {
                
                    block.transform.Translate(Vector2.left * (Speed * Time.deltaTime));

                         
                    if (movemode != 3) { //모드 3은 계속 쭉 걸어가거든 
                        Speed -= deccel;
                    }
                    Flip();
                    //facingRight = true;
                }

                if (move == 2) {

                    block.transform.Translate(Vector2.right * (Speed * Time.deltaTime));

                    if (movemode != 3) {
                    Speed -= deccel;
                    }
                    Flip();
                    //facingRight = false;    
                }

        #endregion 


        if (move != 0 )//(Speed == 0 || Speed < 0 ) {
        {
           // anim.["Pl_MM0_animation"].speed = 0;
          // anim.speed = 0f;
            Animation.speed = 1f;
         
            //Player.transform.localScale = 1;//Quaternion.Euler(0, 0, 0);
           // Animation.mirror = false;

        }else {
            //anim.["Pl_MM0_animation"].speed = 1;
            //anim.speed = 0f;
            Animation.speed = 0f;
            
            //Player.transform.localScale = -1;//Quaternion.Euler(0, 180, 0);
            ///Animation.mirror = true;
        }
    }

    
}
