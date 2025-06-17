using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SetColor : MonoBehaviour
{

    private Renderer rend;
    private Material mat;
    private ColorManager colorManager;

    void Start()
    {
        rend = GetComponent<Renderer>();           
        mat = rend.material;                       
        colorManager = FindAnyObjectByType<ColorManager>();
    }


    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(1))
        {
          
            mat.SetColor("_BaseColor", rend.material.color); 
           
        }
    }


}
