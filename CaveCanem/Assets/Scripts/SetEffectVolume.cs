using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetEffectVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;

    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat("EffectVolume", 0.75f);
    }

    public void SetLevel(float sliderValue)
    {
        float masterValue = PlayerPrefs.GetFloat("MasterVolume", 1f);
        mixer.SetFloat("EffectVol", Mathf.Log10(sliderValue * masterValue) * 20);
        PlayerPrefs.SetFloat("EffectValue", sliderValue);
    }

    public void AdaptToMaster(float sliderValue)
    {
        float masterValue = PlayerPrefs.GetFloat("MasterVolume", 1f);
        mixer.SetFloat("EffectVol", Mathf.Log10(sliderValue * masterValue));
    }
}
