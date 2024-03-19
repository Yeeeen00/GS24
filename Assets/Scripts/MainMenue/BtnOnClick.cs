using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class BtnOnClick : MonoBehaviour
{
    public void StartBtnOnClick()
    {
        BtnClickSound.IsBtnClick = true;
        SceneManager.LoadScene("GameSelectScene");
    }
    public void ExitBtnOnClick()
    {
        BtnClickSound.IsBtnClick = true;
        Application.Quit();
    }
    public void DeveloperBtnOnClick()
    {
        BtnClickSound.IsBtnClick = true;
    }
    public void ReturnMainMenue()
    {
        BtnClickSound.IsBtnClick = true;
        SceneManager.LoadScene("MainScene");
    }
}
