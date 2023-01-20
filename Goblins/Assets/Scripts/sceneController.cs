using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneController : MonoBehaviour
{
    public GameObject endChois;
    public GameObject _count, _menu;
    public GameObject abilityChois;
    public GameObject _image, _LoadingBlock, _image1, _LoadingBlock1;
    [NonSerialized] public bool isOthers = false;
    [NonSerialized] public int count = 0;
    [NonSerialized] public string abilityChosen;

    void Update()
    {
        if (isOthers)
            abilityChosen = null;

        if(Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().name == "Main" && Time.time > 3.5f)
            _menu.SetActive(true);
    }
    
    public void LoadSceneMenu()
    {
        SceneTransition.SwitchToscene("Menu");
    }
    public void LoadSceneMain()
    {
        SceneTransition.SwitchToscene("Main");
    }
    public void ExitFromTheGame() {
        Application.Quit();
    }

    public void closeWindows()
    {
        endChois.SetActive(false);
        count++;
    }
    public void choseStreng()
    {
        abilityChois.SetActive(false);
        abilityChosen = "Сила";
    }
    public void choseAgility()
    {
        abilityChois.SetActive(false);
        abilityChosen = "Ловкость";
    }
    public void choseIntellect()
    {
        abilityChois.SetActive(false);
        abilityChosen = "Интеллект";
    }
    public void closeCount()
    {
        _count.SetActive(false);
        isOthers = true;
        count++;
    }
}