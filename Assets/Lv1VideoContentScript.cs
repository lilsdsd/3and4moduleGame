using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lv1VideoContentScript : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    public List<Sprite> contentImages;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.sprite = contentImages[0];
    }

    // Update is called once per frame
    void ChangeToNextContect()
    {
         if (i == contentImages.Count)
        i++;
        spriteRenderer.sprite = contentImages[i];

       
    }
}
