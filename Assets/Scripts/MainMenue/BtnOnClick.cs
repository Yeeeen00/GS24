using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class BtnOnClick : MonoBehaviour
{
    public GameObject settingpanel;
    float speed = 1000;
    bool IsSettingMove;
    GameObject setting;
    private void Start()
    {
        setting = GameObject.Find("Setting");
    }
    private void Update()
    {
        if (IsSettingMove==true)
        {
            setting.transform.localPosition = 
                Vector3.MoveTowards(setting.transform.localPosition, new Vector3(0,0,0),Time.deltaTime * speed);
        }
        if (IsSettingMove==false)
        {
            setting.transform.localPosition =
                Vector3.MoveTowards(setting.transform.localPosition, new Vector3(0, 980, 0) , Time.deltaTime * speed);
        }
        
    }
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
    public void SettingBtnOnClick()
    {
        BtnClickSound.IsBtnClick = true;
        settingpanel.SetActive(true);
        IsSettingMove = true;
    }
    public void ClosedBtnOnClick()
    {
        BtnClickSound.IsBtnClick = true;
        settingpanel.SetActive(false);
        IsSettingMove = false;
    }
}
