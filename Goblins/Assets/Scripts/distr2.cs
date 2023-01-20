using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class distr2 : MonoBehaviour
{
    private List<Vector3> places = new List<Vector3>();
    public GameObject _Audio;
    public List<GameObject> cards;
    [NonSerialized] public List<GameObject> cards2 = new List<GameObject>();
    public GameObject deck;
    public float speedPosition = 4f, speedRotate = 1500f;

    private void Start()
    {
        Shuffle(cards);
        
        for (int i = 0; i < 19; i++) {
            places.Add(transform.GetChild(i).position);
        }
        
        Destroy(deck.GetComponent<Deck>());
        StartCoroutine(Distr());
    }

    private void Update()
    {
        float step = speedPosition * Time.deltaTime;
        for (int i = 0; i < places.Count; i++)
        {
            if (cards2.Count == i+1)
            {
                cards2[i].transform.position = Vector3.MoveTowards(cards2[i].transform.position, places[i], step);
                if (cards2[i].transform.position != places[i])
                    cards2[i].transform.Rotate(Vector3.down, speedRotate * Time.deltaTime);
            }
        }

        if (cards2.Count == 19 && cards2[cards2.Count-1].transform.position == places[cards2.Count-1])
        {
            Destroy(deck);
            foreach (var el in cards2)
            {
                el.GetComponent<BoxCollider>().enabled = true;
            }

            GetComponent<GameController>().enabled = true;
        }
    }


    IEnumerator Distr()
    {
        foreach (var el in cards)
        {
            
            GameObject card = Instantiate(el, deck.transform.GetChild(0).transform.position, Quaternion.Euler(0, 0, 180));
            _Audio.GetComponent<AudioController>().Card1Sound();
            deck.transform.position = new Vector3(
                deck.transform.position.x,
                deck.transform.position.y - 0.00067f,
                deck.transform.position.z);
            cards2.Add(card);
            yield return new WaitForSeconds(0.3f);
        }
    }



    public static void Shuffle<T>(List<T> list)
    {
        System.Random rand = new System.Random();

        for (int i = list.Count - 1; i >= 0; i--)
        {
            int j = rand.Next(i + 1);
            
            T tmp = list[j];
            list[j] = list[i];
            list[i] = tmp;
        }
    }
}