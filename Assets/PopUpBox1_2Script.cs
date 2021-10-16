using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpBox1_2Script : MonoBehaviour
{
    public GameObject box;
    public CanvasGroup background;

    public Transform chat;

    // Start is called before the first frame update
    private void OnEnable()
    {
        background.alpha = 0;
        background.LeanAlpha(1, 1.5f);

        
     
        box.transform.localPosition = new Vector2( 350f, Screen.height-800);
       //box.transform.localPosition = new Vector2(0, 0);
        box.LeanMoveLocalY(0, 3f).setEaseOutQuart().delay = 0.5f;
        box.LeanMoveLocalX(150f, 3f).setEaseOutQuart().delay = 0.5f;
        //box.LeanMoveLocalY(0, 1.5f).setEaseOutQuart().delay = 0.5f;
        //LeanTween.move(box, new Vector3(0, 1f,0f), 3f).setEaseOutQuart();
        

        LeanTween.rotate(box, new Vector3(0f,0f,0f), 3f).setEaseOutQuart().delay = 0.5f;

        
        //chat.localPosition = new Vector2(Screen.width-2500, -100);//스크린값까지 
       //chat.localPosition = new Vector2(250, -100); // 대각선 
       //chat.localPosition = new Vector2(250, 0); // 대각선 
       chat.LeanMoveLocalX(0f, 2.5f).setEaseOutBack().delay = 2.5f;
       // chat.localPosition = new Vector2(0, -500); 아래에서 뜨는 
        //chat.LeanMoveLocalY(0, 2.5f).setEaseOutBack().delay = 2.5f;
    }

    // Update is called once per frame
    public void ClosePopup()
    {
        background.LeanAlpha(0, 1.5f);
        //box.LeanMoveLocalY(-Screen.height, 2f).setEaseInExpo();
        LeanTween.rotate(box, new Vector3(0f,0f,90f), 2f).setEaseOutQuart();
        box.LeanMoveLocalY(Screen.height, 2f).setEaseOutQuart().delay = 0.5f;
        box.LeanMoveLocalX(-150f, 3f).setEaseOutQuart().delay = 0.5f;
        

        chat.LeanMoveLocalX(Screen.height, 2f).setEaseInExpo().setOnComplete(OnComplete);
    }

    void OnComplete()
    {
       
        gameObject.SetActive(false);
    }
}
