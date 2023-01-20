using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioPanel : MonoBehaviour
{
    public AudioMixerGroup Mixer;
    public Slider sliderMusic, sliderEffects; 
    public Toggle toggleSound;
    public void OnOffMusic() {
        if(toggleSound.GetComponent<Toggle>().isOn)
            Mixer.audioMixer.SetFloat("MasterVolume", 0);
        else
            Mixer.audioMixer.SetFloat("MasterVolume", -80);
    }
    public void ChangeVolumeOfMusic() {
        Mixer.audioMixer.SetFloat("MusicVolume", Mathf.Lerp(-80, 0, sliderMusic.value));
    }

    public void ChangeVolumeOfEffects() {
        Mixer.audioMixer.SetFloat("EffectsVolume", Mathf.Lerp(-80, 0, sliderEffects.value));
    }
}