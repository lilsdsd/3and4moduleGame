using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TextFading : MonoBehaviour
{
public Text text;
/*
void Start(){
    text = GetComponent<Text>();
}*/

public void FadeOut()
{
    StartCoroutine(FadeOutCR());
}

private IEnumerator FadeOutCR()
{
    float duration = 0.5f; //0.5 secs
    float currentTime = 0f;
    while(currentTime < duration)
    {
        float alpha = Mathf.Lerp(1f, 0f, currentTime/duration);
        text.color = new Color(text.color.r, text.color.g, text.color.b, alpha);
        currentTime += Time.deltaTime;
        StartCoroutine(NextScene());
        yield return null;
    }
    yield break;
}

private IEnumerator NextScene(){
    yield return new WaitForSeconds(3);
    SceneManager.LoadScene("Level1");

    yield break;
}

}
