using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnOnClick : MonoBehaviour
{
    public AudioClip AudioClip;
    AudioSource AudioSource;
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }
    public void StartBtnOnClick()
    {
        AudioSource.PlayOneShot(AudioClip);
        Invoke("deley", 0.3f);
    }
    public void ExitBtnOnClick()
    {
        AudioSource.PlayOneShot(AudioClip);
        Invoke("deley2", 0.3f);
    }
    public void DeveloperBtnOnClick()
    {
        AudioSource.PlayOneShot(AudioClip);
    }
    void deley()
    {
        SceneManager.LoadScene("GameSelectScene");
    }
    void deley2()
    {
        Application.Quit();
    }
}
