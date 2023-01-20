using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameController6 : MonoBehaviour
{
    [NonSerialized] public bool oneMove = true;
    void Update()
    {
        if(oneMove) {
            GetComponent<gameController5>().enabled = false;

            GetComponent<gameController3>().oneMove = true;
            GetComponent<gameController4>().oneMove = true;
            GetComponent<gameController5>().oneMove = true;

            GetComponent<gameController4>().playerWin = false;
            GetComponent<gameController4>().computerWin = false;
            GetComponent<gameController4>().draw = false;

            GetComponent<GameController2>().gameIndex = 10;

            oneMove = false;
        }
    }
}
