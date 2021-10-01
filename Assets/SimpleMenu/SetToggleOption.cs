using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetToggleOption : MonoBehaviour
{
    public enum ToggleOption
    {
        InvertYAxis,
    }
    public ToggleOption toggleOption;
    public OptionsObject optionsObject;
    Toggle toggle;
    void Start()
    {
        toggle = this.GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(OnValueChanged);
        switch (toggleOption)
        {
            case ToggleOption.InvertYAxis:
                toggle.SetIsOnWithoutNotify(optionsObject.InvertYAxis);
                break;
        }
    }

    public void OnValueChanged(bool value)
    {
        switch (toggleOption)
        {
            case ToggleOption.InvertYAxis:
                optionsObject.InvertYAxis = value;
                break;
        }
    }


    void Update()
    {
    }
}
