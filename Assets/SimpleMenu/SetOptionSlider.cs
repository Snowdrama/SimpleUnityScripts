using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetOptionSlider : MonoBehaviour
{
    public enum SliderOption
    {
        MasterVolume,
        MusicVolume,
        SoundVolume,
    }
    public SliderOption sliderOption;
    public OptionsObject optionsObject;
    Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = this.GetComponent<Slider>();
        slider.onValueChanged.AddListener(OnValueChanged);
        switch (sliderOption)
        {
            case SliderOption.MasterVolume:
                slider.SetValueWithoutNotify(optionsObject.MasterVolume);
                break;
            case SliderOption.MusicVolume:
                slider.SetValueWithoutNotify(optionsObject.MusicVolume);
                break;
            case SliderOption.SoundVolume:
                slider.SetValueWithoutNotify(optionsObject.SoundVolume);
                break;
        }
    }

    public void OnValueChanged(float value)
    {
        switch (sliderOption)
        {
            case SliderOption.MasterVolume:
                optionsObject.MasterVolume = slider.value;
                break;
            case SliderOption.MusicVolume:
                optionsObject.MusicVolume = slider.value;
                break;
            case SliderOption.SoundVolume:
                optionsObject.SoundVolume = slider.value;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
