using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        float randomScale = Random.Range(1f, 3f);
        transform.localScale = Vector3.one * randomScale;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
