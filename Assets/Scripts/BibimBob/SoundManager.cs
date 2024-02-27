using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClipKnock;
    public static SoundManager instance;
    void Awake()
    {
        if (SoundManager.instance == null)
        {
            SoundManager.instance = this;
        }
    }
    public void PlayKnockSound()
    {
        audioSource.PlayOneShot(audioClipKnock);
    }
    void Update()
    {
        
    }
}
