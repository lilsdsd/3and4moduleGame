using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class PlayerEvent : MonoBehaviour
{
    [SerializeField] private LayerMask platformsLayerMask;
    private State state;
    private State movemode;
    private enum State { //동사, 행동들 
        Idle,
        //SwipeSlowWalking, //움직이지 않음, 스윕으로 걸음 (느릿느릿 걷기) <- State 전환하면 되니까 필요없음 
        SlowWalk,
        SlowWalking, //자동으로 걸음 (느릿느릿 걷기) - 컷씬용?
        BetterWalking, //스윕하게되면, 자동으로 걸음 (좀 나은  걷기)
        NormalWalking, //자동 보통 걷기
        FastWalking, //자동 뛰는듯한걷기
        Running, //자동 뛰기 
        Jump, // 점프
        Flying, 
        Spinning
    }

    public GameObject camObject;
    

   // public GameObject TouchManager; //터치 매니저
    public GameObject Player;  
    public Animator Animation;

   // public Animator Animation;
    public float x1;
    public float x2;
    public float Speed = 2f;
    public float deccel = 0.025f;
    public int move = 0; // 좌우 이동 1 - 좌 2 - 우 0 - 멈춤


    public float zoomSpeed = 0; // 마우스휠이라 필요없음
    public float targetOrtho;
    public float smoothSpeed = 2.0f;
    public float minOrtho = 1.0f;
    public float maxOrtho = 20.0f;


    //Player Components
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
    private SpriteRenderer spriteRenderer;

    //Swipe - not using right now
    public Text outputText;

    private Vector2 startTouchPosition; // start point 
    private Vector2 currentPosition; //
    private Vector2 endTouchPosition;//end
    private bool stopTouch = false;

    public float swipeRange;
    public float tapRange;

    private string swipeDirection;
    
    //Swipe 
    private Vector2 fp; // first finger position
    private Vector2 lp; // last finger position
    private float angle;
    private float swipeDistanceX;
    private float swipeDistanceY;
    public Transform player;

    //For follow mouse
    Vector3 mousePosition;
    //public float moveSpeed = 1f;
    Vector2 position = new Vector2(0f, 0f);//리지드바이 2디도 필요하지만 다른곳에서 이미 선언함

    //For follow Touch

    Vector3 mouseFollowerPosition;
    public Transform mouseFollower;

    //

    public float moveSpeed = 1f;
    public Transform movementControllerPoition;
    private Vector2 movement;


    void Start() {
        //state = State.SlowWalk;
        state = State.Flying;   
        Animation = Player.GetComponent<Animator>();
        rigidbody2d = Player.transform.GetComponent<Rigidbody2D>();
        boxCollider2d = Player.transform.GetComponent<BoxCollider2D>();
        spriteRenderer = Player.GetComponent<SpriteRenderer>();
        
        
        targetOrtho = Camera.main.orthographicSize;
    }

    private void Flip() {
        // Switch the way the player is labelled as facing

        if (move == 2) { //왼쪽보기 

            Vector3 theScale = Player.transform.localScale;
            
            if (theScale.x < 0) {      

                theScale.x *= -1;
               
                Player.transform.localScale = theScale;
            }
        }

        if (move == 1) { //오른쪽보기

            Vector3 theScale = Player.transform.localScale;

            if (theScale.x > 0) {

                    theScale.x *= -1;
                
                    Player.transform.localScale = theScale;
            }
         }
     }

    public void Swipe()
    {
    #region 
        /*
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }


        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            currentPosition = Input.GetTouch(0).position;
            Vector2 Distance = currentPosition - startTouchPosition;

            if (!stopTouch)
            {
                
                if (Distance.x < -swipeRange)
                {
                    swipeDirection = "Left";
                    outputText.text = "Left";
                    stopTouch = true;
                } 
                else if (Distance.x > swipeRange) {

                    swipeDirection = "Right";
                    outputText.text = "Right";
                    stopTouch = true;
                }
                else if (Distance.y > swipeRange){ 
                    swipeDirection = "Up";
                    outputText.text = "Up";
                    stopTouch = true;
                }
                else if (Distance.y < -swipeRange)
                {
                    swipeDirection = "Down";
                    outputText.text = "Down";
                    stopTouch = true;
                }
                else if (Distance.x < -swipeRange && Distance.y > swipeRange)
                {
                    swipeDirection = "Left UP";
                    outputText.text = "Left Up";
                    stopTouch = true;
                } 

            }
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            stopTouch = false;

            endTouchPosition = Input.GetTouch(0).position;

            Vector2 Distance = endTouchPosition - startTouchPosition;

            if (Mathf.Abs(Distance.x) < tapRange && Mathf.Abs(Distance.y) < tapRange)
            {
                outputText.text = "Tap";
            }

        }
        
        foreach(UnityEngine.Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                fp = touch.position;
                lp = touch.position;
            }
            if (touch.phase == TouchPhase.Moved )
            {
                lp = touch.position;
                swipeDistanceX = Mathf.Abs((lp.x-fp.x));
                swipeDistanceY = Mathf.Abs((lp.y-fp.y));
            }
            if(touch.phase == TouchPhase.Ended)
            {
                angle = Mathf.Atan2((lp.x-fp.x),(lp.y-fp.y))*57.2957795f;
                
                if(angle > 60 && angle < 120 && swipeDistanceX > 40 )
                {
                    print ("right");
                    //player.Rotate(0,45,0);
                    swipeDirection = "Right";
                    outputText.text = "Right";
                }

                if (angle > 30 && angle < 60 && swipeDistanceX > 40 && swipeDistanceY > 40) 
                {
                    swipeDirection = "UpRight";
                    outputText.text = "UpRight";
                }

                if (angle > 90 && angle < 150 && swipeDistanceX > 40 && swipeDistanceY > 40)
                {
                    swipeDirection = "DownRight";
                    outputText.text = "DownRight";
                }

                if(angle > 150 || angle < -150 && swipeDistanceY > 40)
                {
                    print ("down");
                    swipeDirection = "Down";
                    outputText.text = "Down";
                   // player.position+=new Vector3(0,-2,0);
                }
                if(angle < -60 && angle > -120 && swipeDistanceX > 40)
                {
                    print ("left");
                    swipeDirection = "Left";
                    outputText.text = "Left";
                    //player.Rotate(0,-45,0);
                }

                if  (angle < -30 && angle > -60 && swipeDistanceX > 40 && swipeDistanceY > 40)
                {
                    swipeDirection = "UpLeft";
                    outputText.text = "Upleft";
                }

                if (angle < -120 && angle > -150 && swipeDistanceX > 40 && swipeDistanceY > 40)
                {
                    swipeDirection = "DownLeft";
                    outputText.text = "DownLeft";
                }

                if(angle > -30 && angle < 30 && swipeDistanceY > 40)
                {
                    print ("up");
                    swipeDirection = "Up";
                    outputText.text = "Up";
                    //player.position+=new Vector3(0,2,0);
                }
            }
        }

    */
    #endregion
    }

    void MobileController(){
       
    }


   
    void Update()
    {
  
        #region // - input system
                            
            if (Input.GetMouseButtonDown(0)) {
                //if (Input.GetTouch(0).phase == TouchPhase.Began) {//모바일 테스트용 
                            
                x1 = Input.mousePosition.x; //터치를 시작한 시점을 측정
            }

            if (Input.GetMouseButtonUp(0)) {
                            
            //if (Input.GetTouch(0).phase == TouchPhase.Ended) { //모바일 테스트용 
                            
                x2 = Input.mousePosition.x; //손가락을 땐 시점을 측정

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


        #region //camera
            float scroll = Input.GetAxis ("Mouse ScrollWheel");

            if (scroll != 0.0f) {
                targetOrtho -= scroll * zoomSpeed;
                targetOrtho = Mathf.Clamp (targetOrtho, minOrtho, maxOrtho);
            }

            Camera.main.orthographicSize = Mathf.MoveTowards (Camera.main.orthographicSize, targetOrtho, smoothSpeed * Time.deltaTime);
     
        #endregion

        #region // STATE에 따라 어떻게 행동이 처리되는지, input에 어떻게 반응할지 결정
            switch(state) {
            

                case State.Idle: //강제 멈춤에 가까움 - swipe 반응 안함, 안움직임, state가 전환될시 천천히 감속해 멈춤
                
                #region //Idle

                    #region //set varriable
                        move = 0;
                        Speed = 0f;
                        deccel = 0.25f;


                        //camera set
                        //camObject.GetComponent<SmoothCamera>().offset = new Vector3(1f, 0.7f, -10f);

                        targetOrtho = 4;

                    #endregion

                    #region //movement
                        if (move == 1) {
                            
                        // Player.transform.Translate(Vector2.left * (Speed * Time.deltaTime));
                        
                            Speed -= deccel;
                        
                            Flip();
                                
                        }

                        if (move == 2) {

                            //Player.transform.Translate(Vector2.right * (Speed * Time.deltaTime));

                            Speed -= deccel;
                                
                            Flip();
                                    
                        }
                    
                #endregion
                
                    #region //-Animation control
                    
                        
                    Animation.SetBool("isSlowWalking", false);
                    Animation.SetBool("isIdle", true);

                        if (Speed > 0 )//(Speed == 0 || Speed < 0 ) {
                            {
                                Animation.speed = 1f;
        
                            }else {
                            
                                Animation.speed = 1f;
    
                            }


                    #endregion

                
                #endregion
                    
                    break; 
               
               
                case State.SlowWalk: //input이 들어와야 움직임 , 천천히 감속하며 멈춤
                
                #region //SlowWalk
                    #region // set varriable
                        
                        deccel = 1.0f;
                        if (Speed == 0 || Speed < 0) {
                            move = 0;
                            Speed = 2f;
                        }

                         //camera set
                        //camObject.GetComponent<SmoothCamera>().offset = new Vector3(1f, 0.7f, -10f);

                        targetOrtho = 4;
            
                    #endregion
                    
                    #region // - movement

                        /* if (move == 1) {
                        
                            Player.transform.Translate(Vector2.left * (Speed * Time.deltaTime));
                    
                            Speed -= deccel*Time.deltaTime;// 천천히 감속함 
                    
                            Flip();
                            
                        }*/

                        if (move == 2) {

                            Player.transform.Translate(Vector2.right * (Speed * Time.deltaTime));

                            Speed -= deccel*Time.deltaTime; // 천천히 감속함 
                            
                            Flip();
                                
                        }

                    #endregion 

                    #region // Animation control

                    Animation.SetBool("isSlowWalking", true);
                    Animation.SetBool("isIdle", false);
                     Animation.SetBool("isNormalWalking",false);

                    if (move != 0 )//(Speed == 0 || Speed < 0 ) {
                            {
                                Animation.speed = 1f;
        
                            }else {
                            
                                Animation.speed = 0f;
    
                            }
                            

                    #endregion
                #endregion
                   
                    break; 
                
                case State.SlowWalking: //input에 영향을 받지 않고 계속 천천히 움직임 

                #region //SlowWaling
                    
                    #region // set varriable
                        //왼쯕으로 갈필요없음
                        
                            move = 2;
                            Speed = 1.0f;
                            deccel = 0.025f;

                            // camObject.GetComponent<SmoothCamera>().offset = new Vector3(1.75f, 0.7f, -10f);

                            targetOrtho = 4.5f;
            
                    #endregion
                    
                    #region // - movement

                        if (move == 2) { 

                            Player.transform.Translate(Vector2.right * (Speed * Time.deltaTime));

                            //Speed -= deccel; // 천천히 감속함 
                            
                            Flip();
                                
                        }

                    #endregion 

                    #region //-Animation control
                        Animation.SetBool("isSlowWalking", true);
                        Animation.SetBool("isIdle", false);
                         Animation.SetBool("isNormalWalking",false);

                        if (Speed > 0 )//(Speed == 0 || Speed < 0 ) {
                            {
                                Animation.speed = 1f;
        
                            }else {
                            
                               // Animation.speed = 0f;
    
                            }


                 
                    #endregion
  
                #endregion

                    break;

                case State.BetterWalking: // 
               
                #region //BetterWalking
                    #region // set varriable
                        //왼쯕으로 갈필요없음
                        
                            move = 2;
                            Speed = 1.55f;
                            deccel = 0.025f;

                            //camObject.GetComponent<SmoothCamera>().offset = new Vector3(1.2f, 0.7f, -10f);

                            targetOrtho = 4.75f;
                    #endregion
                    
                    #region // - movement

                        if (move == 2) { 

                            Player.transform.Translate(Vector2.right * (Speed * Time.deltaTime));

                            //Speed -= deccel; // 천천히 감속함 
                            
                            Flip();
                                
                        }

                    #endregion 

                    #region //-Animation control

                        Animation.SetBool("isSlowWalking",false);
                        Animation.SetBool("isIdle", false);

                        if (Speed > 0 )//(Speed == 0 || Speed < 0 ) {
                            {
                                Animation.speed = 1f;
        
                            }else {
                            
                                //Animation.speed = 0f;
    
                            }
                    #endregion
                #endregion
                    
                    break; 

                case State.NormalWalking:

                #region //NormalWalking

                    #region // set varriable
                        //왼쯕으로 갈필요없음
                        
                            move = 2;
                            Speed = 1.75f;
                            deccel = 0.025f;

                            Animation.SetBool("isSlowWalking",false);
                            Animation.SetBool("isIdle", false);
                            Animation.SetBool("isNormalWalking",false);


                           // camObject.GetComponent<SmoothCamera>().offset = new Vector3(1.2f, 0.7f, -10f);

                            targetOrtho = 5f;
                    #endregion
                    
                    #region // - movement

                        if (move == 2) { 

                            Player.transform.Translate(Vector2.right * (Speed * Time.deltaTime));

                            //Speed -= deccel; // 천천히 감속함 
                            
                            Flip();
                                
                        }

                    #endregion 

                    #region //-Animation control
                        if (Speed > 0 )//(Speed == 0 || Speed < 0 ) {
                            {
                                Animation.speed = 1f;
        
                            }else {
                            
                                Animation.speed = 0f;
    
                            }
                    #endregion

                #endregion
                   
                    break;

                case State.FastWalking:

                #region //FastWalking
                    #region // set varriable
                        //왼쯕으로 갈필요없음
                        
                            move = 2;
                            Speed = 3f;
                            deccel = 0.025f;
                            
                            //camObject.GetComponent<SmoothCamera>().offset = new Vector3(1.2f, 0.7f, -10f);

                            targetOrtho = 6f;
                    #endregion
                    
                    #region // - movement

                        if (move == 2) { 

                            Player.transform.Translate(Vector2.right * (Speed * Time.deltaTime));

                            //Speed -= deccel; // 천천히 감속함 
                            
                            Flip();
                                
                        }

                    #endregion 

                    #region //-Animation control
                        if (Speed > 0 )//(Speed == 0 || Speed < 0 ) {
                            {
                                Animation.speed = 1f;
        
                            }else {
                            
                                Animation.speed = 0f;
    
                            }
                    #endregion
                #endregion
                    
                    break;

                case State.Running:

                #region //Running num7
                        #region // set varriable
                            //왼쯕으로 갈필요없음
                            
                                move = 2;
                                Speed = 5f;
                                deccel = 0.025f;

                                //camObject.GetComponent<SmoothCamera>().offset = new Vector3(5f, 0.5f, -10f);

                                targetOrtho = 8f;
                
                        #endregion
                        
                        #region // - movement

                            if (move == 2) { 

                                Player.transform.Translate(Vector2.right * (Speed * Time.deltaTime));

                                //Speed -= deccel; // 천천히 감속함 
                                
                                Flip();
                                    
                            }

                             if(Input.GetKeyDown(KeyCode.Space)) {
                                    float jumpVelocity = 10f;
                                    rigidbody2d.velocity = Vector2.up * jumpVelocity;
                                }

                        #endregion 

                        #region //-Animation control
                             Animation.SetTrigger("Jump");
                                

                              if (IsGrounded()) {
                        
                                }
                            
                            if (Speed > 0 )//(Speed == 0 || Speed < 0 ) {
                                {
                                    Animation.speed = 1f;
            
                                }else {
                                
                                    Animation.speed = 0f;
        
                                }
                        #endregion
                    #endregion

                    break;

                case State.Jump:

                    
                #region // set varriable
                    //camObject.GetComponent<SmoothCamera>().offset = new Vector3(3.5f, 0.5f, -10f);
                         

                
                   // targetOrtho = 8f;
                  if(Input.GetKeyDown(KeyCode.Space)) {
                    float jumpVelocity = 10f;
                    rigidbody2d.velocity = Vector2.up * jumpVelocity;
                  }
                #endregion

                    if (move == 2) { 

                            Player.transform.Translate(Vector2.right * (Speed * Time.deltaTime));

                            //Speed -= deccel; // 천천히 감속함 
                            
                            Flip();
                                
                        }

                #region //Animation control

                    Animation.SetTrigger("Jump");
                

                #endregion

                    if (IsGrounded()) {
                        
                    }

                    break;



                case State.Flying: //대기상태   float

                //camObject.GetComponent<SmoothCamera>().offset = new Vector3(0f, 0f, -10f);
               // camObject.GetComponent<SmoothCamera>().damping = 1f;
                Animation.SetBool("isFloat",true);
                Animation.SetBool("isSlowWalking",false);
                //Physics2D.gravity = new Vector2(0, Physics2D.gravity.y * 0);
                Physics2D.gravity = new Vector2(0, 0);

                Vector3 direction = movementControllerPoition.position - transform.position;
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                rigidbody2d.rotation = angle;
                direction.Normalize();
                movement = direction;

                //mobile Controller
               /* foreach(UnityEngine.Touch theTouch in Input.touches)
                {
                    if (Input.touchCount > 0)
                    {
                        touchPosition = Input.GetTouch(0);
                        touchPosition = Camera.main.ScreenToWorldPoint(touchPosition);

                        if ((touchPosition.phase == TouchPhase.Began || touchPosition.phase == TouchPhase.Stationary 
                        || touchPosition.phase == TouchPhase.Moved))
                        {
                            position = Vector2.Lerp(transform.position, touchPosition, moveSpeed);

                            Vector2 direction = new Vector2(
                            touchPosition.x - transform.position.x,
                            touchPosition.y - transform.position.y
                            );
                            
                            transform.right = direction;
                            
                        }else {
                        position = Vector2.Lerp(transform.position, touchPosition, moveSpeed);
                        }
                    }
                }*/


                //mouseController
                /*
                if ( Input.GetMouseButton(0)){
                    mousePosition = Input.mousePosition;
                    mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                    position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);

                //마우스 바라보기 

                    Vector2 direction = new Vector2(
                        mousePosition.x - transform.position.x,
                        mousePosition.y - transform.position.y
                    );
                    transform.right = direction;
                        
                    


                }else {
                    position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
                //마우스 바라보기 
                }
                */
                
                
                
                   


                


                /*
                targetOrtho = 8f;              


                Swipe();

                if( swipeDirection == "Right") {
                      state = State.Spinning;
                    Animation.SetBool("isSpinning",true);
                    Animation.SetBool("isFloat",false);

                    
                    float moveVelocity = 9f;
                    rigidbody2d.velocity = Vector2.right * moveVelocity;
                    //rigidbody2d.MovePosition(transform.position + Vector2.right * Time.fixedDeltaTime);
                     rigidbody2d.drag = 0.75f;

                    
                }

                  if( swipeDirection == "Up") {
                      state = State.Spinning;
                    Animation.SetBool("isSpinning",true);
                    Animation.SetBool("isFloat",false);

                    transform.eulerAngles = new Vector3 (0, 0, 90);

                   // transform.Rotate(0,0,90);
                    float moveVelocity = 9f;
                    rigidbody2d.velocity = Vector2.up * moveVelocity;
                    //rigidbody2d.MovePosition(transform.position + Vector2.right * Time.fixedDeltaTime);
                     rigidbody2d.drag = 0.75f;

                    
                  }

                if( swipeDirection == "Left") {
                      state = State.Spinning;
                    Animation.SetBool("isSpinning",true);
                    Animation.SetBool("isFloat",false);
                    
                    spriteRenderer.flipY = true;
                    transform.eulerAngles = new Vector3 (0, 0, 180);
                   // transform.Rotate(0,0,180);
                    float moveVelocity = -4.5f;
                    rigidbody2d.velocity = Vector2.right * moveVelocity;
                    //rigidbody2d.MovePosition(transform.position + Vector2.right * Time.fixedDeltaTime);
                     rigidbody2d.drag = 0.75f;
                }

                if( swipeDirection == "Down") {
                      state = State.Spinning;
                    Animation.SetBool("isSpinning",true);
                    Animation.SetBool("isFloat",false);
                    
                    transform.eulerAngles = new Vector3 (0, 0, 270);
                    //spriteRenderer.flipY = true;
                    //transform.Rotate(0,0,270);
                    float moveVelocity = -9f;
                    rigidbody2d.velocity = Vector2.up * moveVelocity;
                    //rigidbody2d.MovePosition(transform.position + Vector2.right * Time.fixedDeltaTime);
                     rigidbody2d.drag = 0.75f;
                }
                
                if( swipeDirection == "DownRight") {
                      state = State.Spinning;
                    Animation.SetBool("isSpinning",true);
                    Animation.SetBool("isFloat",false);

                    transform.eulerAngles = new Vector3 (0, 0, 315);
                    //spriteRenderer.flipY = true;
                    //transform.Rotate(0,0,315);
                    float moveVelocity = 4.5f;
                    rigidbody2d.velocity = new Vector2(moveVelocity, -moveVelocity);
                    
                    rigidbody2d.drag = 0.75f;
                }

                  if( swipeDirection == "DownLeft") {
                      state = State.Spinning;
                    Animation.SetBool("isSpinning",true);
                    Animation.SetBool("isFloat",false);
                    
                    transform.eulerAngles = new Vector3 (0, 0, 225);
                    //spriteRenderer.flipY = true;
                    //stransform.Rotate(0,0,225);
                    float moveVelocity = 4.5f;
                    rigidbody2d.velocity = new Vector2(-moveVelocity, -moveVelocity);
                    //rigidbody2d.velocity = Vector2.right * Vector2.up * moveVelocity;
                    //rigidbody2d.velocity = Vector2.right * moveVelocity;
                    //rigidbody2d.velocity = Vector2.up * moveVelocity;
                    //rigidbody2d.MovePosition(transform.position + Vector2.right * Time.fixedDeltaTime);
                     rigidbody2d.drag = 0.75f;
                }

                  if( swipeDirection == "UpRight") {
                      state = State.Spinning;
                    Animation.SetBool("isSpinning",true);
                    Animation.SetBool("isFloat",false);
                    
                    transform.eulerAngles = new Vector3 (0, 0, 45);
                    //spriteRenderer.flipY = true;
                    //transform.Rotate(0,0,45);
                    float moveVelocity = 4.5f;
                    rigidbody2d.velocity = new Vector2(moveVelocity, moveVelocity);
                     rigidbody2d.drag = 0.75f;
                }

                  if( swipeDirection == "UpLeft") {
                      state = State.Spinning;
                    Animation.SetBool("isSpinning",true);
                    Animation.SetBool("isFloat",false);
                    
                    transform.eulerAngles = new Vector3 (0, 0, 135);
                    //spriteRenderer.flipY = true;
                  //transform.Rotate(0,0,135);
                    float moveVelocity = 4.5f;
                    rigidbody2d.velocity = new Vector2(-moveVelocity, moveVelocity);
                    
                     rigidbody2d.drag = 0.75f;
                }*/
                    break;

                case State.Spinning: //스핀 상태 
                foreach(UnityEngine.Touch touch in Input.touches)
                {
                
                    }
               // camObject.GetComponent<SmoothCamera>().offset = new Vector3(0f, 1f, -10f);
                //camObject.GetComponent<SmoothCamera>().damping = 0.25f;
                    if(Animation.GetBool("isSpinning") == true) {
                        Animation.SetBool("isFloat",false);
                    
                        
                    }
                    if(Animation.GetBool("isSpinning") == false) {
                        Debug.Log("State를 Flying으로 변환합니다");
                          state = State.Flying;
                            Animation.SetBool("isFloat",true);
                            

                            if (swipeDirection == "Up") {
                                 // transform.Rotate(0,0,-90);
                                 transform.eulerAngles = new Vector3 (0, 0, 0);
                            }
                            if (swipeDirection == "Left") {
                                //  transform.Rotate(0,0,-180);
                                transform.eulerAngles = new Vector3 (0, 0, 0);
                                  spriteRenderer.flipY = false;
                            }
                            if (swipeDirection == "Down") {
                                 // transform.Rotate(0,0,-270);
                                 transform.eulerAngles = new Vector3 (0, 0, 0);
                                  spriteRenderer.flipY = false;
                            }
                            if (swipeDirection == "DownRight") {
                               // transform.Rotate(0,0, -315);
                               transform.eulerAngles = new Vector3 (0, 0, 0);
                                
                            }
                            if (swipeDirection == "UpRight") {
                               // transform.Rotate(0,0, -45);
                               transform.eulerAngles = new Vector3 (0, 0, 0);
                            }
                            if (swipeDirection == "UpLeft") {
                               // transform.Rotate(0,0, -135);
                               transform.eulerAngles = new Vector3 (0, 0, 0);
                            }
                            if (swipeDirection == "DownLeft") {
                              //  transform.Rotate(0,0, -225);
                              transform.eulerAngles = new Vector3 (0, 0, 0);
                                
                            }
                            
                            swipeDirection = null;
                            outputText.text = "Waiting...";
                          
                    } 

                    //Swipe();
                    

                    break;


            }

        #endregion

        #region // test-number control
            
            var input = Input.inputString;

            switch(input){
                case "1" :
                        Debug.Log("1 pressed - Idle");

                        state = State.Idle;

                    break;
                
                case "2" :
                        Debug.Log("2 pressed - SlowWalk");

                         state = State.SlowWalk;
                    break;

                case "3" :
                    Debug.Log("3 pressed - SlowWaking");

                        state = State.SlowWalking;
                break;

                case "4" :
                    Debug.Log("4 pressed - BetterWalking");

                        state = State.BetterWalking;
                break;

                
                case "5" :
                    Debug.Log("5 pressed - NormalWalking");

                        state = State.NormalWalking;
                break;

                case "6" :
                    Debug.Log("6 pressed - FastWalking");

                        state = State.FastWalking;
                break;

                case "7" :
                    Debug.Log("7 pressed - Running");

                        state = State.Running;
                break;

                case "8" :
                    Debug.Log("8 pressed - Jump");

                        state = State.Jump;
                break;

                case "9" :
                    Debug.Log("9 pressed - Flying");

                        state = State.Flying;
                break;

                case "0" :
                    Debug.Log("0 pressed - Spinning");

                        state = State.Spinning;
                break;

                case "/" :
                    Debug.Log ("Your state is now "+state + "입니다."); 
                break;
            }

        #endregion

        if(Input.GetKeyDown(KeyCode.R)){
            Debug.Log("commander reqest - restart game");
            SceneManager.LoadScene(0);
                  }
            }


    private void FixedUpdate() {
        //rigidbody2d.MovePosition(position);
        moveCharacter(movement);
    }

    void OnCollisionEnter2D(Collision2D other) { // - 충돌 이벤트 트리거들 - 틜거에 따라 state를 변경
        #region //패턴1-1
            if (other.gameObject.name == "pettern_1_1")//(other.gameObject.name == "coin")
            {
                    
                Debug.Log("정상작동합니다");
                    
                // TouchManager.GetComponent<Touch>().enabled = false; //터치 인풋을 비활성화함

                Debug.Log("터치 비활성화");
                    //Animation.speed = 0f;
                Destroy(other.gameObject);  

            }
        #endregion 
    }
    
    void moveCharacter(Vector2 direction) {
        rigidbody2d.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
   

    private bool IsGrounded() {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down * .1f, platformsLayerMask);
       // Debug.Log("Grounded");
        return raycastHit2d.collider != null;
    }


}
