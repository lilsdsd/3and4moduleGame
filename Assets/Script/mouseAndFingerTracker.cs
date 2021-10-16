using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseAndFingerTracker : MonoBehaviour
{

    [SerializeField] private Camera mainCamera;
    // Update is called once per frame
    private void LateUpdate()
    {
        if (Input.GetMouseButton(0)){
        //Debug.Log(Input.mousePosition);
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        transform.position = mouseWorldPosition;
        }
    }
}
