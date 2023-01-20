using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public GameObject plane;
    void OnMouseDown () 
    {
        plane.GetComponent<distr2>().enabled = true;
        GetComponent<Renderer>().material.color = Color.blue;
    }
}
