using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SetColor : MonoBehaviour
{

    private Material mat;
    private ColorManager colorManager;

    void Start()
    {
        mat = GetComponent<Renderer>().material;                      
        colorManager = FindAnyObjectByType<ColorManager>();
    }


    void OnMouseDown()
    {
       
       mat.color = colorManager.selectedColor;
           
        
    }

    void Update()
    { 
        if(Input.GetMouseButtonDown(1))
        {
            mat.SetColor("_BaseColor", Color.white);
        }
            
    }

}
