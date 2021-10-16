using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BookShelfBookScript : MonoBehaviour
{
   
   // [SerializeField] Transform[] Positions;
    [SerializeField] float ObjectSpeed = 1f;

    int NextPosIndex;
    Vector3 NextPos;
    Vector3 OriginalPos;
    Color OrinalColor;
    public bool isInteresting;
    bool isMovingUp;
    public bool isDetected;
    public GameObject orangeBook;

    public GameObject PopUpGroup;

    public float bookSizeX = 0.35f;
    public float bookSizeY = 0.49f;
    public float bookTweenSizeX = 0.37f;
    public float bookTweenSizeY = 0.52f;
    //private Transform body;
    public float MoveTime = 0.5f;
    public float MoveDistance = 0.01f;

    public bool isInterClicked = false; // 스크립트 억세스할때, 관심있는 책이 발견되는 경우를 찾기위한
    

    void Awake(){
        OriginalPos = transform.position;
        OrinalColor = this.gameObject.GetComponent<SpriteRenderer>().color;
    }

    void Start(){
         
        NextPos = transform.position + new Vector3(0,MoveDistance,0);//new Vector3(body.position.x, body.position.y , body.position.z) + new Vector3(0,MoveDistance,0);
        isDetected = false;
    
    }

    void OnMouseOver(){
        //Debug.Log("MouseHovered");
    
        if (isMovingUp == false && isDetected == false){
            StartCoroutine(Movement());
            isMovingUp = true;
            
        }else{

        }

        if (isInteresting == true && isDetected == false){
            StartCoroutine(ChangeColorOrange());
            isDetected = true;
        } else if(isInteresting == false && isDetected == false) {
            StartCoroutine(ChangeColorBrown());
            isDetected = true;
        }
    }

    void OnMouseExit()
    {
        // Debug.Log("Mouse UnHovered");
         isMovingUp = false;
         StartCoroutine(MoveBack());

    }

    void OnMouseDown(){
       
        if (isInteresting == true){
            Debug.Log("U clicked orangebook");
            PopUpGroup.SetActive(true);
            orangeBook.SetActive(false);
            isInterClicked = true;
        }
    }




    IEnumerator Movement(){
        

        LeanTween.move(this.gameObject, NextPos, MoveTime).setEaseInOutBack();
        LeanTween.scale(this.gameObject, new Vector3(bookTweenSizeX,bookTweenSizeY,1), MoveTime).setEaseInOutBack();

        yield break;
    } 

    private IEnumerator MoveBack(){
        if(isMovingUp == false){
   
            yield return new WaitForSeconds(0.5f);
                    LeanTween.move(this.gameObject, OriginalPos, MoveTime).setEaseInOutBack();
                    LeanTween.scale(this.gameObject, new Vector3(bookSizeX,bookSizeY,1), MoveTime).setEaseInOutBack();

                    yield break;
            }
            yield break;
        }
         

   
    IEnumerator ChangeColorOrange(){

        LeanTween.color(this.gameObject, new Color(255/255f,157/255f,10/255f,255/255f),1f).setDelay(0.2f);
        yield return new WaitForSeconds(5f);

        //StartCoroutine(ReturnToOriginColor());
        yield break;

    }

    IEnumerator ChangeColorBrown(){
       
         LeanTween.color(this.gameObject, new Color(87/255f,79/255f,65/255f,255/255f), 1f).setDelay(0.2f);
         yield return new WaitForSeconds(5f);

        //StartCoroutine(ReturnToOriginColor());
        isDetected = false;
        yield break;
        
    }

    public IEnumerator ReturnToOriginColor(){
        LeanTween.color(this.gameObject, OrinalColor,1f);
        yield break;

    }
}


    

