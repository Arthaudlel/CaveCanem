using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetMusicVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;

    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
    }

    public void SetLevel(float sliderValue)
    {
        float masterValue = PlayerPrefs.GetFloat("MasterVolume", 1f);
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue * masterValue) * 20);
        PlayerPrefs.SetFloat("MusicValue", sliderValue);
    }

    public void AdaptToMaster(float sliderValue)
    {
        float masterValue = PlayerPrefs.GetFloat("MasterVolume", 1f);
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue * masterValue));
    }
}
