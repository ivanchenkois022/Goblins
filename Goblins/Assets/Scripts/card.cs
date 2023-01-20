using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class card : MonoBehaviour
{
    [NonSerialized] public int strength, agility, intellect;
    [NonSerialized] public string _name, _nameOnCard;
    [NonSerialized] public bool inGame = false;
    [NonSerialized] public string useAbility = null;
    [NonSerialized] public int abilityValue;
    [NonSerialized] public bool lose = false;
    private Animator anim;
    void Start()
    {
        string n = gameObject.name;
		_name = n.Substring(0, n.Length-7);
        strength = GetComponent<abilityes>().searchAbility(_name, "strength");
        agility = GetComponent<abilityes>().searchAbility(_name, "agility");
        intellect = GetComponent<abilityes>().searchAbility(_name, "intellect");

        transform.GetChild(0).transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = Convert.ToString(strength);
        transform.GetChild(0).transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = Convert.ToString(agility);
        transform.GetChild(0).transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = Convert.ToString(intellect);

        string[] str = _name.Split('_');
        _nameOnCard =String.Join(' ', str);

        
        transform.GetChild(0).transform.GetChild(6).GetComponent<TextMeshProUGUI>().enableAutoSizing = true;

        if(_nameOnCard.Length > 9)
            transform.GetChild(0).transform.GetChild(6).GetComponent<TextMeshProUGUI>().fontSizeMin = 0.85f;
        else
            transform.GetChild(0).transform.GetChild(6).GetComponent<TextMeshProUGUI>().fontSizeMin = 0.65f;
        
        transform.GetChild(0).transform.GetChild(6).GetComponent<TextMeshProUGUI>().text = _nameOnCard;

        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (inGame)
        {
            if (useAbility == "Сила")
            {
                transform.GetChild(0).transform.GetChild(0).GetComponent<Image>().color = Color.red;
                transform.GetChild(0).transform.GetChild(3).GetComponent<TextMeshProUGUI>().color= Color.red;
                abilityValue = strength;
            }
            else if (useAbility == "Ловкость")
            {
                transform.GetChild(0).transform.GetChild(1).GetComponent<Image>().color = Color.green;
                transform.GetChild(0).transform.GetChild(4).GetComponent<TextMeshProUGUI>().color = Color.green;
                abilityValue = agility;
            }
            else if (useAbility == "Интеллект")
            {
                transform.GetChild(0).transform.GetChild(2).GetComponent<Image>().color = Color.blue;
                transform.GetChild(0).transform.GetChild(5).GetComponent<TextMeshProUGUI>().color = Color.blue;
                abilityValue = intellect;
            }
        }
        
        if (lose)
        {
            transform.GetChild(0).transform.GetChild(7).GetComponent<Image>().enabled = true;   
        }
    }
}
