using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level1JoystickScript : MonoBehaviour
{
    public GameObject background;
    //public GameObject handle;
    public GameObject Joystick;

    private CanvasGroup JoyCanGroup;

    public float ShowUpTime = 5.5f;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        //background.SetActive(false);
        //handle.SetActive(false);
        //Joystick.canvasRenderer.SetAlpha (0.0f);
        JoyCanGroup = Joystick.GetComponent<CanvasGroup>();

       
       JoyCanGroup.alpha = 0f;
        
        yield return new WaitForSeconds(ShowUpTime);
        
        ShowUp();
    }

    // Update is called once per frame
    void ShowUp(){
           
             JoyCanGroup.alpha = 1f;
            //https://www.youtube.com/watch?v=t8xcHFMtLZQ 이걸로 나중에 페이드 구현
     
        //background.SetActive(true);
       // handle.SetActive(true);
        //Joystick.canvasRenderer.SetAlpha (1f);

        //return;
    }
}
