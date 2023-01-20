using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
 
    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
    
    
}
