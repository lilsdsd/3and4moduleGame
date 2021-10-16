using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBookSceneScript : MonoBehaviour
{
    public CanvasGroup Obj;
    // Start is called before the first frame update
    void Start()
    {
        Obj.LeanAlpha(1f, 5f).setDelay(5f);
    }
}
