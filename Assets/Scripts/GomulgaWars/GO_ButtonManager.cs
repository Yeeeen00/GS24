using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GO_ButtonManager : MonoBehaviour
{
    public AudioClip BtnclickSound;
    AudioSource BtnclickSoundSource;
    public GameObject StopPanel;
    public GameObject StopImage;
    private void Start()
    {
        BtnclickSoundSource = GetComponent<AudioSource>();
    }
    public void OnReStartBtnOnoClick()
    {
        BtnclickSoundSource.PlayOneShot(BtnclickSound);
        Invoke("Restoncl", 0.25f);
    }
    public void ReTryOnclick()
    {
        SceneManager.LoadScene("GomulgaWars");
        GO_GameManager.BGMStop = false;
        GO_GameManager.Stage -= 1;
        if (GO_GameManager.Stage > 1)
            GO_PlayerScript.P_num = GO_PlayerScript.SaveNum + Random.Range(-2, 3);
    }
    public void OnRestart()
    {
        BtnclickSoundSource.PlayOneShot(BtnclickSound);
        Invoke("Rest", 0.25f);
    }
    public void OnContinueOnClick()
    {
        BtnclickSoundSource.PlayOneShot(BtnclickSound);
        Time.timeScale = 1;
        GO_GameManager.BGMStop = false;
        StopPanel.SetActive(false);
        StopImage.SetActive(false);
    }
    public void ExitMainScene()
    {
        
    }
    void Rest()
    {
        SceneManager.LoadScene("GomulgaWars");
        GO_GameManager.BGMStop = false;
        GO_PlayerScript.P_num = GO_PlayerScript.SaveNum;
    }
    void Restoncl()
    {
        SceneManager.LoadScene("GomulgaWars");
        GO_GameManager.BGMStop = false;
        GO_PlayerScript.P_num /= 10;
    }
}
