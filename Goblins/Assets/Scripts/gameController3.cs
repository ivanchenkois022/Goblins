using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gameController3 : MonoBehaviour
{
    [NonSerialized] public GameObject cardPl, cardCp;
    public GameObject _cum, _abilityChois, _choisenMoving, _abilityComputerChose, _Audio;
    private List<GameObject> cardPlayer = new List<GameObject>();
    private List<GameObject> cardComputer = new List<GameObject>();
    private string abil = null;
    [NonSerialized] public bool oneMove = true;


    void Update()
    {
        if(oneMove) {        
            foreach (var el in GetComponent<GameController2>().cardPlayer)
            {
                cardPlayer.Add(el);
            }

            foreach (var el in GetComponent<GameController2>().cardComputer)
            {
                cardComputer.Add(el);
            }

            cardPl = cardPlayer[cardPlayer.Count - 1];
            cardCp = cardComputer[cardComputer.Count - 1];
            
            GetComponent<GameController2>().gameIndex = 20;
            

            if(GetComponent<GameController2>().isPlayerMove)
                StartCoroutine(playerCardsMove());
            else if(!GetComponent<GameController2>().isPlayerMove){
                abil = abilityComputerChose();
                StartCoroutine(computerCardsMove());
            }
            oneMove = false;
        }
    }

    IEnumerator playerCardsMove()
    {
        cardPl.GetComponent<CardMoving>().countMoving = 3;
        yield return new WaitForSeconds(0.8f);
        cardCp.GetComponent<CardMoving>().countMoving = 2;
        yield return new WaitForSeconds(0.8f);


        cardPl.GetComponent<card>().inGame = cardCp.GetComponent<card>().inGame = true;
        cardPl.GetComponent<card>().useAbility = cardCp.GetComponent<card>().useAbility = _cum.GetComponent<sceneController>().abilityChosen;
        yield return new WaitForSeconds(0.8f);
        GetComponent<gameController4>().enabled = true;
    }

    IEnumerator computerCardsMove()
    {
        _abilityComputerChose.SetActive(true);
        yield return new WaitForSeconds(0.8f);

        _abilityComputerChose.SetActive(false);
        yield return new WaitForSeconds(0.8f);
                
        _cum.GetComponent<sceneController>().abilityChosen = abil;
       
        cardCp.GetComponent<CardMoving>().countMoving = 2;
        yield return new WaitForSeconds(0.8f);
        cardPl.GetComponent<CardMoving>().countMoving = 3;
        yield return new WaitForSeconds(0.8f);


        cardPl.GetComponent<card>().inGame = cardCp.GetComponent<card>().inGame = true;
        cardPl.GetComponent<card>().useAbility = cardCp.GetComponent<card>().useAbility = _cum.GetComponent<sceneController>().abilityChosen;
        yield return new WaitForSeconds(0.8f);
        GetComponent<gameController4>().enabled = true;
        
    }
    public string abilityComputerChose() {
        string abil = null;
                
        System.Random rand = new System.Random();
        int ch = rand.Next(3);


        if(ch == 0) {
            abil = "Сила";
            _abilityComputerChose.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = languageController.MSText3;;
            _abilityComputerChose.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().color = Color.red;
        }
        else if(ch == 1) {
            abil = "Ловкость";
            _abilityComputerChose.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = languageController.MSText4;
            _abilityComputerChose.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().color = Color.green;
        }
        else if(ch == 2) {
            abil = "Интеллект";
            _abilityComputerChose.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = languageController.MSText5;
            _abilityComputerChose.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().color = Color.blue;
        }
        return abil;
    }

}