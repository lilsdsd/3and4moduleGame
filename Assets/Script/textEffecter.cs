using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textEffecter : MonoBehaviour
{
    public float HorizonMove;
    public float VertiMove;
    TMP_Text textMesh;

    Mesh mesh;

    Vector3[] vertices;

    List<int> wordIndexes;

    List<int> wordLengths;

    void Start()
    {
        textMesh = GetComponent<TMP_Text>();

        wordIndexes = new List<int>{0};
        wordLengths = new List<int>();

        string s = textMesh.text;

        for (int index = s.IndexOf(' '); index > -1; index = s.IndexOf(' ', index+ 1))
        {

            wordLengths.Add(index - wordIndexes[wordIndexes.Count - 1]);
            wordIndexes.Add(index + 1);
        }
        wordLengths.Add(s.Length - wordIndexes[wordIndexes.Count -1]);


    } 

    // Update is called once per frame
    void Update()
    {
        textMesh.ForceMeshUpdate();
        mesh = textMesh.mesh;
        vertices = mesh.vertices;

        for (int w = 0; w < wordIndexes.Count; w++)
        {

            int wordIndex = wordIndexes[w];
            Vector3 offset = Wobble(Time.time + w);
        

            for( int i = 0; i < wordLengths[w]; i++){
                
                TMP_CharacterInfo c = textMesh.textInfo.characterInfo[wordIndex+i];

                int index = c.vertexIndex;
                vertices[index] += offset;
                vertices[index+1] += offset;
                vertices[index+2] += offset;
                vertices[index+3] += offset;
            }
        }

        mesh.vertices = vertices;
        textMesh.canvasRenderer.SetMesh(mesh);
    }

    Vector2 Wobble(float time) {
        return new Vector2(Mathf.Sin(time*HorizonMove), Mathf.Cos(time*VertiMove));
    }
}
