using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "OptionsObject", menuName = "OptionsObject")]
public class OptionsObject : ScriptableObject
{
    [SerializeField] private float _masterVolume;
    public float MasterVolume
    {
        get { return _masterVolume; }
        set { 
            _masterVolume = value;
            Save();
        }
    }
    [SerializeField] private float _musicVolume;
    public float MusicVolume
    {
        get { return _musicVolume; }
        set { 
            _musicVolume = value;
            Save();
        }
    }
    [SerializeField] private float _soundVolume;
    public float SoundVolume
    {
        get { return _soundVolume; }
        set { 
            _soundVolume = value;
            Save();
        }
    }
    [SerializeField] private bool _invertYAxis;
    public bool InvertYAxis
    {
        get { return _invertYAxis; }
        set { 
            _invertYAxis = value;
            Save();
        }
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("MasterVolume", _masterVolume);
        PlayerPrefs.SetFloat("MusicVolume", _musicVolume);
        PlayerPrefs.SetFloat("SoundVolume", _soundVolume);
        PlayerPrefs.SetInt("InvertYAxis", (_invertYAxis)? 1 : 0);
    }

    public void Load()
    {
        _masterVolume = PlayerPrefs.GetFloat("MasterVolume", 1);
        _musicVolume = PlayerPrefs.GetFloat("MusicVolume", 1);
        _soundVolume = PlayerPrefs.GetFloat("SoundVolume", 1);
        _invertYAxis = PlayerPrefs.GetInt("InvertYAxis", 1) == 1 ? true : false;
    }

    [System.NonSerialized] bool initialized;
    public void OnEnable()
    {
        if(!initialized)
        {
            Load();
        }
    }

    private void OnDisable()
    {
        Save();
    }
}
