using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckMarkGroupChecker : MonoBehaviour
{
    public GameObject FirstButton;
    public GameObject SecondButton;
    public GameObject ApplyButton;
    public GameObject NotificationScreen;
    public GameObject TYPESSCREEN;

    private Color enabledColor;
    private Color disabledColor;
    // Start is called before the first frame update
    void Start()
    {
        Color disabledColor = new Color(209/255f, 209/255f,209/255f,255/255f);
        Color enabledColor = new Color(184/255, 145/255, 95/255, 255/255);
        ApplyButton.GetComponent<Image>().color = disabledColor;
    }

    // Update is called once per frame
    public void ButtonCheck()
    {
        if(
        FirstButton.GetComponent<Toggle>().isOn == true 
        &&  SecondButton.GetComponent<Toggle>().isOn == true)
        {
            ApplyButton.GetComponent<Image>().color = new Color32(184, 145, 95, 255);

            Debug.Log("신청하기 버튼을 갈색으로 변환 합니다 ");
        } else{
             ApplyButton.GetComponent<Image>().color = new Color32(209, 209,209,255);
        }
    }

    public void ApplyButtonClicked(){
        
        if(
        FirstButton.GetComponent<Toggle>().isOn == true 
        &&  SecondButton.GetComponent<Toggle>().isOn == true)
        {
            Debug.Log("Notificationscreen을 제거하고 Typescreen을 활성화합니다");
            NotificationScreen.SetActive(false);
            TYPESSCREEN.SetActive(true);
        }
    }
}
