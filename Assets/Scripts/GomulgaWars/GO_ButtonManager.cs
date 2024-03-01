using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GO_ButtonManager : MonoBehaviour
{
    public GameObject StopPanel;
    public GameObject StopImage;
    public void OnReStartBtnOnoClick()
    {
        SceneManager.LoadScene("GomulgaWars");
        GO_PlayerScript.P_num /= 10;
    }
    public void ReTryOnclick()
    {
        SceneManager.LoadScene("GomulgaWars");
        if(GO_GameManager.Stage!=1)
            GO_PlayerScript.P_num = GO_PlayerScript.SaveNum + Random.Range(-2,3);
    }
    public void OnRestart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("GomulgaWars");
        GO_GameManager.Stage -= 1;
        GO_PlayerScript.P_num = GO_PlayerScript.SaveNum;
    }
    public void OnContinueOnClick()
    {
        Time.timeScale = 1;
        StopPanel.SetActive(false);
        StopImage.SetActive(false);
    }
    public void ExitMainScene()
    {

    }
}
