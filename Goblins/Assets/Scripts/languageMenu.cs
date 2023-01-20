using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class languageMenu : MonoBehaviour
{
    void Update()
    {   
        //главное меню
        transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text =languageController.MMButton1; 
        transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = languageController.MMButton2;
        transform.GetChild(3).transform.GetChild(0).GetComponent<Text>().text = languageController.MMButton3;
        transform.GetChild(4).transform.GetChild(0).GetComponent<Text>().text = languageController.MMButton4;

        transform.GetChild(5).transform.GetChild(0).GetComponent<Text>().text = languageController.SoundBotton1;

        //Панель загрузки карт
        transform.GetChild(6).transform.GetChild(1).GetComponent<Text>().text = languageController.MMText1;
        transform.GetChild(6).transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = languageController.MMButton4;
        
        //Панель выбора языка
        transform.GetChild(7).transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = languageController.MMButton5;
        transform.GetChild(7).transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = languageController.MMButton6;
        transform.GetChild(7).transform.GetChild(3).transform.GetChild(0).GetComponent<Text>().text = languageController.MMButton4;

        //Панель звука
        transform.GetChild(8).transform.GetChild(1).GetComponent<Text>().text = languageController.SoundText1;
        transform.GetChild(8).transform.GetChild(3).GetComponent<Text>().text = languageController.SoundText2;
        transform.GetChild(8).transform.GetChild(5).transform.GetChild(1).GetComponent<Text>().text = languageController.SoundText3;
        transform.GetChild(8).transform.GetChild(6).transform.GetChild(0).GetComponent<Text>().text = languageController.MMButton4;
    }
}