using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupBoxScript : MonoBehaviour
{
    public Transform box;
    public CanvasGroup background;

    public Transform chat;

    // Start is called before the first frame update
    private void OnEnable()
    {
        background.alpha = 0;
        background.LeanAlpha(1, 1.5f);

        box.localPosition = new Vector2(0, -Screen.height+800);
        box.LeanMoveLocalY(0, 1.5f).setEaseOutBack().delay = 0.5f;

        
        //chat.localPosition = new Vector2(Screen.width-2500, -100);//스크린값까지 
       //chat.localPosition = new Vector2(250, -100); // 대각선 
       chat.localPosition = new Vector2(250, 0); // 대각선 
       chat.LeanMoveLocalX(0, 2.5f).setEaseOutBack().delay = 2.5f;
       // chat.localPosition = new Vector2(0, -500); 아래에서 뜨는 
        //chat.LeanMoveLocalY(0, 2.5f).setEaseOutBack().delay = 2.5f;
    }

    // Update is called once per frame
    public void ClosePopup()
    {
        background.LeanAlpha(0, 1.5f);
        box.LeanMoveLocalY(-Screen.height, 2f).setEaseInExpo();

        chat.LeanMoveLocalX(Screen.height, 2f).setEaseInExpo().setOnComplete(OnComplete);
    }

    void OnComplete()
    {
       
        gameObject.SetActive(false);
    }
}
