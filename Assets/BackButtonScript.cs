using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonScript : MonoBehaviour
{
    //만약  리스트에 있는 (팝업)게임오브젝트들이 전부 비활성화 일때, 홈화면으로 복귀 합니다.
    //혹은 어떤 팝업이 떠있을시, 비활성화합니다.

    public List<GameObject> Elements;
    public bool isElseToGo = false;
    public string ifElseSceneToGo;
    private int numberOfActive;
    // Start is called before the first frame update

    void Start()
    {
        numberOfActive = Elements.Count;
       
        //ifElseSceneToGo = null;
    }
    public void BackButtonPressed()
    {
        if (Elements.Count == 0 && string.IsNullOrWhiteSpace(ifElseSceneToGo) == true)
        {
            Debug.Log("BackButton: 리스트에 있는 element가 없음으로 홈화면으로 복귀합니다");
            SceneManager.LoadScene("Lv1MainScreen");
        }
        else if (Elements.Count == 0 && string.IsNullOrWhiteSpace(ifElseSceneToGo) == false)
        {
            Debug.Log("BackButton: 리스트에 있는 element가 없음으로 홈화면으로 복귀합니다" + " 그리고 입력된 씬으로 이동합니다");
            SceneManager.LoadScene(ifElseSceneToGo);
        }
        else
        {
            for (int i = 0; i < Elements.Count; i++)
            {
                if (Elements[i].activeSelf)
                {
                    Elements[i].SetActive(false);
                    Debug.Log("BackButton: 리스트에 있는 element를 감지해 비활성화 합니다.");
                    numberOfActive = Elements.Count;
                    break;
                }
                else
                {
                    numberOfActive -= 1;
                    if (numberOfActive <= 0 && string.IsNullOrWhiteSpace(ifElseSceneToGo) == true)
                    {
                        Debug.Log("BackButton: 활성화된 element가 없음으로 홈화면으로 복귀합니다");
                        SceneManager.LoadScene("Lv1MainScreen");
                    }
                    else if (numberOfActive <= 0 && string.IsNullOrWhiteSpace(ifElseSceneToGo) == false)
                    {
                        Debug.Log("BackButton: 활성화된 element가 없음으로 홈화면으로 복귀합니다" + " 그리고 입력된 씬으로 이동합니다");
                        SceneManager.LoadScene(ifElseSceneToGo);
                    }

                }
            }


        }


    }
}
