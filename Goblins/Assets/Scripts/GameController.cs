using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
	private int countScene = 0;
    [NonSerialized] public List<GameObject> cardDefault = new List<GameObject>();
    [NonSerialized] public List<GameObject> cardPlayer = new List<GameObject>();
    [NonSerialized] public  List<GameObject> cardComputer = new List<GameObject>();
    public GameObject _endChois;
    public GameObject _cum, _Audio;
    
    private void Start()
    {
        foreach (var el in GetComponent<distr2>().cards2)
        {
            cardDefault.Add(el);
        }
        GetComponent<distr2>().enabled = false;
    }

    private void Update()
    {
        int chetNeChet = cardDefault.Count % 2;

        if (cardDefault.Count > 1)
        {
            foreach (var el in cardDefault)
            {
                if (el.GetComponent<CardMoving>().countMoving == 1)
                {
                    cardPlayer.Add(el);
                    _Audio.GetComponent<AudioController>().Card2Sound();
                    cardDefault.Remove(el);
                }
            }
        }

        if (chetNeChet == 0)
        {
            foreach (var el in cardDefault)
            {
                el.GetComponent<BoxCollider>().enabled = false;
            }

            int indx = Random.Range(0, cardDefault.Count);
            cardDefault[indx].GetComponent<CardMoving>().tag = "Computer";
            cardComputer.Add(cardDefault[indx]);
            _Audio.GetComponent<AudioController>().Card2Sound();
            cardDefault.Remove(cardDefault[indx]);

        }
        else if (chetNeChet == 1 && cardDefault.Count != 1)
        {
            foreach (var el in cardDefault)
            {
                el.GetComponent<BoxCollider>().enabled = true;
            }
        }
        else if (chetNeChet == 1 && cardDefault.Count == 1 && _cum.GetComponent<sceneController>().count == 0)
        {
            _endChois.SetActive(true);
            cardDefault[0].GetComponent<CardMoving>().tag = "Others";

        }

        if (_cum.GetComponent<sceneController>().count == 1 && countScene == 0)
        {
            _cum.GetComponent<CameraMoving>().enabled = true;
            foreach (var el in cardPlayer)
            {
                el.GetComponent<CardMoving>().countMoving++;
            }

            foreach (var el in cardComputer)
            {
                el.GetComponent<CardMoving>().countMoving++;
            }
            countScene ++;
            
        }

        if(_cum.transform.position == _cum.GetComponent<CameraMoving>().positionPoint)
            gameObject.GetComponent<GameController2>().enabled = true;
    }
}