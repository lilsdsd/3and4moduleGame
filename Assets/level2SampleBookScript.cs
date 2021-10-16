using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class level2SampleBookScript : MonoBehaviour,IPointerDownHandler, IBeginDragHandler, IEndDragHandler,IDragHandler, IDropHandler
{
    public HealthBar healthBar;
    
    public int maxHealth = 4;
    public int currentHealth;

    public GameObject TheCatPicReaction;
    public GameObject HealthBarObj;
    public GameObject Janbaguni;

    public bool DragMode = false;

    BoxCollider2D col;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    [SerializeField] private Canvas canvas;


    void Awake(){
        
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        healthBar.SetMaxHealth(maxHealth);
        col = GetComponent<BoxCollider2D>();

        currentHealth = maxHealth;
        col.enabled = false;
        addPhysics2DRaycaster();
        DislikeIt(4);
    }

   //public List<GameObject> LikeElements = new List<GameObject>();

    void addPhysics2DRaycaster()
    {
        Physics2DRaycaster physicsRaycaster = GameObject.FindObjectOfType<Physics2DRaycaster>();
        if (physicsRaycaster == null)
        {
            Camera.main.gameObject.AddComponent<Physics2DRaycaster>();
        }
    }


    public void OnBeginDrag(PointerEventData eventData) {
        
            
            canvasGroup.blocksRaycasts = false;
            LeanTween.scale(this.gameObject, new Vector3(0.4f,0.4f,0.4f), 0.5f);
            LeanTween.color(this.gameObject, new Color(255/255f,157/255f,10/255f,255/255f),1f).setDelay(0.2f);
            Debug.Log("OnBeginDrag");
            
    }

    public void OnDrag(PointerEventData eventData) {
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta/ canvas.scaleFactor;
       
    }

    public void OnEndDrag(PointerEventData eventData) {
        Debug.Log("OnEndDrag");
        canvasGroup.blocksRaycasts = true;
    }

    public void OnDrop(PointerEventData eventData) {
        LeanTween.scale(this.gameObject, new Vector3(0.1f,0.1f,0.1f), 0.5f).setEaseInExpo();
        throw new System.NotImplementedException();
         
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        if (DragMode == false){
            if (eventData.pointerCurrentRaycast.gameObject.tag == "LikeElement"){
                Debug.Log("Clicked: " + eventData.pointerCurrentRaycast.gameObject.name);

                if (eventData.pointerCurrentRaycast.gameObject.name == "catpic"){
                    
                    TheCatPicReaction.SetActive(true);
                    TheCatPicReaction.transform.localPosition = new Vector2(250, -50); // 대각선 
                    TheCatPicReaction.LeanMoveLocalX(0, 1).setEaseOutBack().delay = 0.5f;
                    LikeIt(1);
                }
        }

        else if (DragMode == true){
             Debug.Log("OnMouse");
        }

        
        }

       

    }

    void LikeIt(int like)
    {
        currentHealth += like; 
        healthBar.SetHealth(currentHealth);

        if (currentHealth == maxHealth) {
            HealthBarObj.LeanMoveLocalX(-Screen.height-400f, 2f).setEaseInExpo();
            DragMode = true;
            col.enabled = true;
            Janbaguni.SetActive(true);
            Janbaguni.transform.localPosition = new Vector2(-Screen.width, 0f);
            Janbaguni.LeanMoveLocalX(-175f,2f).setEaseOutBack().setDelay(2f);
        

        }



    }

    void DislikeIt(int dislike)
    {
        currentHealth -= dislike; 
        healthBar.SetHealth(currentHealth);
    }

  

}