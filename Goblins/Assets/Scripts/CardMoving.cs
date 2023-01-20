using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMoving : MonoBehaviour
{
    public GameObject table2;
    private List<Vector3> places2 = new List<Vector3>();
    private float speedPosition = 1.5f, speedRotation = 30f;
    [NonSerialized] public int countMoving = 0;

    private void Start()
    {
        for (int i = 0; i < 9; i++)
            places2.Add(table2.transform.GetChild(i).position);

    }
    

    private void Update()
    {
        if (tag == "Player" && countMoving == 1)
            move1();
        else if(tag == "Computer" && countMoving == 0)
            move2();
        else if(tag == "Others")
            move3();
        
        if(tag == "Computer" && countMoving == 1)
            move4();
        else if(tag == "Player" && countMoving == 2)
            move5();
        
        if(tag == "Computer" && countMoving == 2)
            move6();
        else if(tag == "Player" && countMoving == 3)
            move7();
    }

    private void move1()
    {
        float step = speedPosition * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, places2[1], step);
        transform.rotation = Quaternion.Euler(0, 0, 180f);
        GetComponent<BoxCollider>().enabled = false;
    }
    private void move2()
    {
        float step = speedPosition * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, places2[0], step);
        transform.rotation = Quaternion.Euler(0, 0, 180f);
        GetComponent<BoxCollider>().enabled = false;
    }
    
    private void move3()
    {
        float step = speedPosition * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, places2[2], step);
        GetComponent<BoxCollider>().enabled = false;
    }
    private void move4()
    {
        float step = speedPosition * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, places2[3], step/2f);
        GetComponent<BoxCollider>().enabled = false;
    } 
    private void move5()
    {
        float step = speedPosition * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, places2[4], step/2f);
        GetComponent<BoxCollider>().enabled = false;
    }

    private void move6()
    {
        float step = speedPosition * Time.deltaTime;
        float stepRotate = speedRotation * Time.deltaTime;
        if (transform.position.z > places2[5].z)
        {
            transform.position = Vector3.MoveTowards(transform.position, places2[5], step / 2f);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 180), stepRotate);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, places2[6], step / 2f);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), stepRotate);
        }
        GetComponent<BoxCollider>().enabled = false;
    }
    private void move7()
    {
        float step = speedPosition * Time.deltaTime;
        float stepRotate = speedRotation * Time.deltaTime;
        if (transform.position.z < places2[7].z)
        {
            transform.position = Vector3.MoveTowards(transform.position, places2[7], step / 2f);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 180), stepRotate);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, places2[8], step / 2f);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), stepRotate);
        }
        GetComponent<BoxCollider>().enabled = false;
    } 

    void OnMouseDown () 
    {
        GetComponent<Renderer>().material.color = Color.blue;
        tag = "Player";
        countMoving ++;
    }
}