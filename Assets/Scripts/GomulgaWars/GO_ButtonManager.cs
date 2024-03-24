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
        BtnClickSound.IsBtnClick = true;
        SceneManager.LoadScene("GomulgaWars");
        GO_GameManager.BGMStop = false;
        GO_PlayerScript.P_num /= 10;
    }
    public void ReTryOnclick()
    {
        BtnClickSound.IsBtnClick = true;
        SceneManager.LoadScene("GomulgaWars");
        GO_GameManager.BGMStop = false;
        GO_GameManager.Stage -= 1;
        if (GO_GameManager.Stage > 1)
            GO_PlayerScript.P_num = GO_PlayerScript.SaveNum + Random.Range(-2, 3);
    }
    public void OnRestart()
    {
        BtnClickSound.IsBtnClick = true;
        SceneManager.LoadScene("GomulgaWars");
        GO_GameManager.BGMStop = false;
        GO_PlayerScript.P_num = GO_PlayerScript.SaveNum;
    }
    public void OnContinueOnClick()
    {
        BtnClickSound.IsBtnClick = true;
        Time.timeScale = 1;
        GO_GameManager.BGMStop = false;
        StopPanel.SetActive(false);
        StopImage.SetActive(false);
        GO_GameManager.Escbtncheck = 0;
    }
    public void ExitMainScene()
    {
        BtnClickSound.IsBtnClick = true;
        GO_PlayerScript.P_num = 0;
        GO_GameManager.Stage = 0;
        GO_PlayerScript.SaveNum = 0;
        SceneManager.LoadScene("GameSelectScene");
        Time.timeScale = 1;
    }
}
