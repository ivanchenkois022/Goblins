using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameController5 : MonoBehaviour
{
    [NonSerialized] public GameObject cardPl, cardCp;
    public GameObject _cum;
    private bool endround = false;
    [NonSerialized] public bool oneMove = true;
    void Update()
    {
        if(oneMove) {
            cardPl = GetComponent<gameController4>().cardPl;
            cardCp = GetComponent<gameController4>().cardCp;

            GetComponent<gameController4>().enabled = false;
            
            StartCoroutine(endRound());

            oneMove = false;
        }
    }
    IEnumerator endRound() {
        cardPl.tag = cardCp.tag = "Others";
        yield return new WaitForSeconds(0.1f);
        GetComponent<GameController2>().cardPlayer.Remove(cardPl);
        GetComponent<GameController2>().cardComputer.Remove(cardCp);

        _cum.GetComponent<sceneController>().isOthers = false;
        _cum.GetComponent<sceneController>().abilityChosen = null;
        GetComponent<GameController2>().isPlayerMove = !GetComponent<GameController2>().isPlayerMove;
        yield return new WaitForSeconds(0.8f);
        
        GetComponent<gameController6>().enabled = true;
    }
}