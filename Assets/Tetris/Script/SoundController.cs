using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum SoundClip
{
    Drop,
    Explo,
    Explo4,
    GameStart,
    GameOver
}
public class SoundController : MonoBehaviour
{
    public AudioClip A_Drop, A_Explo, A_Explo4lines, A_GameStart, A_GameOver;
    public AudioSource myAudio;

    public void PlaySound(SoundClip audioType)
    {
        switch (audioType)
        {
            case SoundClip.Drop:
                myAudio.clip = A_Drop;
                break;
            case SoundClip.Explo:
                myAudio.clip = A_Explo;
                break;
            case SoundClip.Explo4:
                myAudio.clip = A_Explo4lines;
                break;
            case SoundClip.GameStart:
                myAudio.clip = A_GameStart;
                break;
            case SoundClip.GameOver:
                myAudio.clip = A_GameOver;
                break;
        }

        myAudio.Play();
    }
}