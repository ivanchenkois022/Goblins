using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameController4 : MonoBehaviour
{
    [NonSerialized] public GameObject cardPl, cardCp;
    public GameObject _cum, _count, _Audio;
    private bool  endround = false;
    [NonSerialized] public bool playerWin = false, computerWin = false, draw = false, oneMove = true;
      
    void Update () {
        if(oneMove) {
            cardPl = GetComponent<gameController3>().cardPl;
            cardCp = GetComponent<gameController3>().cardCp;

            GetComponent<gameController3>().enabled = false;

            StartCoroutine(count());

            oneMove = false;
        }
        if(_cum.GetComponent<sceneController>().isOthers == true && endround)
            GetComponent<gameController5>().enabled = true;
    }
    IEnumerator count() {
        yield return new WaitForSeconds(0.8f);
        countRound();
        yield return new WaitForSeconds(1f);
        _count.SetActive(true);
        yield return new WaitForSeconds(0.8f);
        endround = true;
    }
    private void countRound()
    {
        if (cardPl.GetComponent<card>().abilityValue > cardCp.GetComponent<card>().abilityValue)
            playerWin = true;
        else if (cardPl.GetComponent<card>().abilityValue < cardCp.GetComponent<card>().abilityValue)
            computerWin = true;
        else 
            draw = true;
                
        if (playerWin)
        {
            GetComponent<GameController2>().playerCounter ++;
            _count.transform.GetChild(0).transform.GetChild(5).GetComponent<Text>().text = languageController.MSText6;
            cardCp.GetComponent<card>().lose = true;
        }

        if (computerWin)
        {
            GetComponent<GameController2>().computerCounter++;
            _count.transform.GetChild(0).transform.GetChild(5).GetComponent<Text>().text = languageController.MSText7;
            cardPl.GetComponent<card>().lose = true;
        }

        if (draw)
        {
            _count.transform.GetChild(0).transform.GetChild(5).GetComponent<Text>().text = languageController.MSText8;
        }
        _Audio.GetComponent<AudioController>().CardFail();
    }
}
