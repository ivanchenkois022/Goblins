using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController2 : MonoBehaviour
{
    [NonSerialized] public List<GameObject> cardPlayer = new List<GameObject>();
    [NonSerialized] public List<GameObject> cardComputer = new List<GameObject>();
    public GameObject _abilityChois, _count, _cum, _choisenMoving, _finalCount, _menu;
    public Text ability;
    [NonSerialized] public int playerCounter = 0, computerCounter = 0;
    [NonSerialized] public bool isPlayerMove = true;
    [NonSerialized] public byte gameIndex = 0;
    void Start()
    {
        foreach (var el in GetComponent<GameController>().cardPlayer)
        {
            cardPlayer.Add(el);
        }

        foreach (var el in GetComponent<GameController>().cardComputer)
        {
            cardComputer.Add(el);
        }

        _choisenMoving.SetActive(true);
        GetComponent<GameController>().enabled = false;
    }
    void Update()
    {
        string finalCount = null;
        _menu.transform.GetChild(0).transform.GetChild(3).GetComponent<Text>().text = Convert.ToString(playerCounter);
        _menu.transform.GetChild(0).transform.GetChild(4).GetComponent<Text>().text = Convert.ToString(computerCounter);
        
        
        _count.transform.GetChild(0).transform.GetChild(3).GetComponent<Text>().text = Convert.ToString(playerCounter);
        _count.transform.GetChild(0).transform.GetChild(4).GetComponent<Text>().text = Convert.ToString(computerCounter);
        
        abilityFon();
        
        switch(gameIndex) {
            case 10:
                if(cardPlayer.Count != 0) {
                    GetComponent<gameController6>().enabled = false;
                    GetComponent<gameController6>().oneMove = true;
                    if(isPlayerMove){
                        if(_cum.GetComponent<sceneController>().abilityChosen != null)
                            GetComponent<gameController3>().enabled = true;
                        else if(_cum.GetComponent<sceneController>().abilityChosen == null)
                            _abilityChois.SetActive(true);
                    } else if(!isPlayerMove) {
                        GetComponent<gameController3>().enabled = true;
                    }
                }else if (cardPlayer.Count == 0) {
                    _finalCount.SetActive(true);
                    _finalCount.transform.GetChild(0).transform.GetChild(3).GetComponent<Text>().text = Convert.ToString(playerCounter);
                    _finalCount.transform.GetChild(0).transform.GetChild(4).GetComponent<Text>().text = Convert.ToString(computerCounter);
                    
                    if(playerCounter > computerCounter)
                        finalCount = languageController.MSText16;
                    else if(playerCounter < computerCounter)
                        finalCount = languageController.MSText17;
                    else if(playerCounter == computerCounter)
                        finalCount = languageController.MSText18;

                    _finalCount.transform.GetChild(0).transform.GetChild(5).GetComponent<Text>().text = finalCount;
                }
                break;
            case 20:
                break;
               
        }
    }
    private void abilityFon()
    {
        //ability.text = _cum.GetComponent<sceneController>().abilityChosen;
        if(_cum.GetComponent<sceneController>().abilityChosen == "Сила") {
            ability.color = Color.red;
            ability.text = languageController.MSText3;
        }
        else if(_cum.GetComponent<sceneController>().abilityChosen == "Ловкость") {
            ability.color = Color.green;
            ability.text = languageController.MSText4;
        }
        else if(_cum.GetComponent<sceneController>().abilityChosen == "Интеллект") {
            ability.color = Color.blue;
            ability.text = languageController.MSText5;
        }
        else {
            ability.color = Color.white;
            ability.text = _cum.GetComponent<sceneController>().abilityChosen;
        }
    }
    public void playerMove()
    {
        _choisenMoving.SetActive(false);
        isPlayerMove = true;
        gameIndex = 10;
    }
    public void computerMove()
    {   

        _choisenMoving.SetActive(false);
        isPlayerMove = false;
        gameIndex = 10;
    }
}