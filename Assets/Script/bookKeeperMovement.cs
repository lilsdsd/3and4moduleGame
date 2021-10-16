using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookKeeperMovement : MonoBehaviour
{

    // 랜덤하게 이동하지않고, 특정구역을 지키는 오브젝트 


    /* - 랜덤 이동 구현
    public float speed = 2.0f;
    public float xPos;
    public float timer = 1f;
    public Vector3 desiredPos;
    public float timerSpeed = 1f;
    public float timeToMove = 10f;

     void Start()
     {
         xPos = Random.Range(-4.5f, 4.5f);
         desiredPos = new Vector3(xPos, transform.position.y, transform.position.z);
     }
 
     void Update()
     {
         timer += Time.deltaTime * timerSpeed;
         if (timer >= timeToMove)
         {
             transform.position = Vector3.Lerp(transform.position, desiredPos, Time.deltaTime * speed);
             if (Vector3.Distance(transform.position, desiredPos) <= 0.01f)
             {
                 xPos = Random.Range(-4.5f, 4.5f);
                 desiredPos = new Vector3(xPos, transform.position.y, transform.position.z);
                 timer = 0.0f;
             }
         }
     }*/

    public float speed = 0.05f;
    public float yPos;
    public float timer = 1f;
    public Vector3 desiredPos;
    public float timerSpeed = 1f;
    public float timeToMove = 2f;

     void Start()
     {
         //xPos = Random.Range(-4.5f, 4.5f);
         yPos = Random.Range(-0.05f, 0.05f);
        // desiredPos = new Vector3(xPos, transform.position.y, transform.position.z);
        desiredPos = new Vector3(transform.position.x, yPos, transform.position.z);
     }
 
     void Update()
     {
        timer += Time.deltaTime * timerSpeed;
        if (timer >= timeToMove)
        {
            transform.position = Vector3.Lerp(transform.position, desiredPos, Time.deltaTime * speed);
            if (Vector3.Distance(transform.position, desiredPos) <= 0.01f)
            {
                yPos = Random.Range(-0.05f, 0.05f);
                desiredPos = new Vector3(transform.position.x, yPos, transform.position.z);
                timer = 0.0f;
            }
         }
     }
}
