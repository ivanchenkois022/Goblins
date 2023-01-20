using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilityes : MonoBehaviour
{
    public string[,] abilities = new string[,]
    {
        {"Gazloy", "5", "3", "2"}, 
        {"Bolg", "4", "2", "2"}, 
        {"Kalo", "4", "3", "1"}, 
        {"Gryh", "3", "2", "1"},
        {"Uurljuk", "3", "1", "2"},
        {"Moca", "3", "2", "0"},
        {"Kli_Kli", "2", "5", "3"},
        {"Leprekon", "2", "4", "2"}, 
        {"Rumpelstilzchen", "1", "4", "3"}, 
        {"Kikimer", "1", "3", "2"}, 
        {"Dobby", "2", "3", "1"},
        {"Iz_Iz", "1", "3", "1"},
        {"Normack", "3", "2", "5"},
        {"Galhano", "2", "2", "4"},
        {"Zarzevicks", "3", "1", "4"},
        {"Bogus", "1", "2", "3"},
        {"Varnabo", "2", "1", "3"},
        {"Gogel_Mogel", "1", "1", "3"},
        {"Krjukohvat", "3", "3", "3"}
    };

    public int searchAbility(string name, string ability)
    {
        int abilValue= 0;
        int abilIndex  = 0;

        if(ability == "strength")
            abilIndex = 1;
        else if (ability == "agility")
            abilIndex = 2;
        else if (ability == "intellect")
            abilIndex = 3;

        for(byte i = 0; i < 19; i ++) {
            if(abilities[i, 0] == name)
                abilValue = Convert.ToInt32(abilities[i,abilIndex]);
        }
        return abilValue;
    }

}

