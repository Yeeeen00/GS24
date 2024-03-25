using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class VolumeSet : MonoBehaviour
{
    GameObject bgmobj;
    GameObject soundobj;
    static public float BGMvolume = 1;
    static public float soundVolume = 1;
    private void Start()
    {
        bgmobj = GameObject.Find("BGM(Clone)");
        soundobj = GameObject.Find("ButtonClickSound(Clone)");
    }
    public void SetLevel(float sliderValue)
    {
        BGMvolume = sliderValue;
        bgmobj.GetComponent<AudioSource>().volume = sliderValue;
    }
    public void SetSound(float sliderValue)
    {
        soundVolume = sliderValue;
        soundobj.GetComponent<AudioSource>().volume = sliderValue;
    }
}
