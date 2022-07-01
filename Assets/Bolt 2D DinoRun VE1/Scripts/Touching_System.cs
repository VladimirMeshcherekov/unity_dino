using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touching_System : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject Dino;
    
    private void OnMouseDown()
    {
        Dino.GetComponent<dinoController>().IsTouching(true);
        
    }    
    private void OnMouseUp()
    {
        Dino.GetComponent<dinoController>().IsTouching(false);
       
        
    }
}
