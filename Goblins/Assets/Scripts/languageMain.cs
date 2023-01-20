using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class languageMain : MonoBehaviour
{
    public GameObject _endChiois, _abilityChois, _count, _choiseMove, _abilityComputerChoise, _finalCount, _menu;
    void Update()
    {
        _endChiois.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = languageController.MSText1;
        _endChiois.transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = languageController.MSButton1;

        _abilityChois.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = languageController.MSText2;
        _abilityChois.transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = languageController.MSText3;
        _abilityChois.transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = languageController.MSText4;
        _abilityChois.transform.GetChild(3).transform.GetChild(0).GetComponent<Text>().text = languageController.MSText5;

        _count.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = languageController.MSText9;
        _count.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = languageController.MSText10;
        _count.transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = languageController.MSButton2;

        _choiseMove.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = languageController.MSText12;
        _choiseMove.transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = languageController.MSButton3;
        _choiseMove.transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = languageController.MSButton4;
        
        _abilityComputerChoise.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = languageController.MSText15;

        _finalCount.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = languageController.MSText9;
        _finalCount.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = languageController.MSText10;
        _finalCount.transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = languageController.MSButton5;
        _finalCount.transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = languageController.MSButton6;

        _menu.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = languageController.MSText9;
        _menu.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = languageController.MSText10;
        _menu.transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = languageController.MSButton7;
        _menu.transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = languageController.MSButton6;
        _menu.transform.GetChild(3).transform.GetChild(0).GetComponent<Text>().text = languageController.SoundBotton1;
        //sound
        _menu.transform.GetChild(4).transform.GetChild(0).GetComponent<Text>().text = languageController.SoundText1;
        _menu.transform.GetChild(4).transform.GetChild(2).GetComponent<Text>().text = languageController.SoundText2;
        _menu.transform.GetChild(4).transform.GetChild(4).transform.GetChild(1).GetComponent<Text>().text = languageController.SoundText3;
        _menu.transform.GetChild(4).transform.GetChild(5).transform.GetChild(0).GetComponent<Text>().text = languageController.MMButton4;
    }
}