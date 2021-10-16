using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookAroundMovement : MonoBehaviour
{
    public GameObject target;
    public float speedForce = 5.0f;
    public Rigidbody2D rigidbody;
    public float angle;
    public float timer = 1f;

    public float timerSpeed = 1f;
    public float timeToMove = 2f;

    Vector2 dir;
   

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        
        
        //angle = Random.Range(0, 360f);
        //Vector3 dir = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.right;
            
        rigidbody.AddForce(transform.forward * speedForce);
    
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * timerSpeed;
        if (timer >= timeToMove)
        {
            
            dir = target.transform.position - transform.position;
            dir = dir.normalized;
            rigidbody.AddForce(dir * speedForce);

        }
    }
}
