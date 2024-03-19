using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnClickSound : MonoBehaviour
{
    public AudioClip audioClip;
    AudioSource audioSource;
    public static bool IsBtnClick;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(IsBtnClick==true)
        { 
            audioSource.PlayOneShot(audioClip); 
            IsBtnClick = false;
        }
    }
}
