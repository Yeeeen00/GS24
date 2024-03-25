using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundVol : MonoBehaviour
{
    private void Start()
    {
        if(gameObject.name=="BgmSlider")
            GetComponent<Slider>().value= VolumeSet.BGMvolume;
        else if(gameObject.name=="ButtonSlider")
            GetComponent<Slider>().value = VolumeSet.soundVolume;
    }
}
