using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lv1PasswordController : MonoBehaviour
{
    [SerializeField] InputField field;
    [SerializeField] Text text;
    [SerializeField] string pw = "1234";
    // Start is called before the first frame update
    void Start()
    {
        field.text = "";
        text.text = "비밀번호를 입력하세요";
    }

    // Update is called once per frame
    void Update()
    {
        if(field.text == pw){
            text.text = "열렸습니다 ";
        }else{
            if(field.text.Length > 6){
                field.text = "";
            }
            text.text = "비밀번호를 입력하세요";
        }
    }
}
