using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//OpenningSceneScript
public class OpenningSceneScript: MonoBehaviour
{

    bool isFading = false;
    float fadeAlpha = 1f;
    public Image image;
    public float fadeOutTime = 0.2f;
    public GameObject OpenningSceneObj;

    void Start() {
        // image = GetComponent<Image>();
    }
    
    //public TMP_Text textComponent; //- 웨이브효과용 선언




   /* void Update()
    {

        #region // 웨이브 효과


        /*
        textComponent.ForceMeshUpdate();
        var textInfo = textComponent.textInfo;

        for (int i = 0; i < textInfo.characterCount; ++i) {
            var charInfo = textInfo.characterInfo[i];

            if (!charInfo.isVisible) {
                continue;
            }

            var verts = textInfo.meshInfo[charInfo.materialReferenceIndex].vertices;

            for (int j = 0; j < 4; ++j) {
                var orig = verts[charInfo.vertexIndex + j];
                verts[charInfo.vertexIndex + j] = orig + new Vector3(0, Mathf.Sin(Time.time*2f + orig.x*0.01f) * 10f, 0);
            }

        }

        for (int i = 0; i < textInfo.meshInfo.Length; ++i ) {
            var meshInfo = textInfo.meshInfo[i];
            meshInfo.mesh.vertices = meshInfo.vertices;
            textComponent.UpdateGeometry(meshInfo.mesh, i);
        }
    }
    #endregion


        
     //  textComponent.faceColor = new Color32(255, 255, 255, 255);

      //  StartCoroutine("FadeOut");
    }
*/
    void OnMouseDown() {
        StartCoroutine("FadeOut");
        Debug.Log("clicked");
    }

    IEnumerator FadeOut() 
    {
       // for(float fadeAlpha = 1f; fadeAlpha >=0; fadeAlpha -= 0.1f){
           while(fadeAlpha >= 0f) {
            
            Debug.Log ("it worked");
            Debug.Log (fadeAlpha);
            
            image.color =  new Color(image.color.r, image.color.g, image.color.b, fadeAlpha);
            fadeAlpha -= Time.deltaTime / fadeOutTime;
            yield return null;//yield return new WaitForSeconds(1f);
        }
            if (fadeAlpha <= 0){
                Destroy(OpenningSceneObj.gameObject);
            }
                //Destroy(OpenningSceneObj.gameObject);
            image.color =  new Color(image.color.r, image.color.g, image.color.b, fadeAlpha);
    }

}

