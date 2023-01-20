using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public GameObject buttonSound;
    public  GameObject card1Sound;
    public  GameObject card2Sound;
    public  GameObject cardFail;
    public void ButtonSound() {
        buttonSound.GetComponent<AudioSource>().Play();
    }
    public void Card1Sound() {
        card1Sound.GetComponent<AudioSource>().Play();
    }
    public void Card2Sound() {
        card2Sound.GetComponent<AudioSource>().Play();
    }
    public void CardFail() {
        cardFail.GetComponent<AudioSource>().Play();
    }
}