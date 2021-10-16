using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class le1_P1_clickevent : MonoBehaviour
{
/*
    #region // 터피된 오브젝트를 선택하는 코드 
    private GameObject target;

    void FixedUpdate() {

        if (Input.GetMouseButtonDown (0)) {

            CastRay ();

            if (target == this.gameObject) {  //타겟 오브젝트가 스크립트가 붙은 오브젝트라면
                // 여기에 실행할 코드를 적습니다.

                    var book = 


            } 
        }
    }
    
    
    void CastRay() // 유닛 히트처리 부분.  레이를 쏴서 처리합니다. 
    {

        target = null;



        Vector2 pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);

        RaycastHit2D hit = Physics2D.Raycast (pos, Vector2.zero, 0f);



        if (hit.collider != null) { //히트되었다면 여기서 실행

        Debug.Log (hit.collider.name);  //이 부분을 활성화 하면, 선택된 오브젝트의 이름이 찍혀 나옵니다. 

        target = hit.collider.gameObject;  //히트 된 게임 오브젝트를 타겟으로 지정

        }

    }

    #endregion */



}
