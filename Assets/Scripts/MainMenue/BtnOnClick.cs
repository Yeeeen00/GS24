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
    int Pos;
    string Panelname;
    private void Update()
    {
        if (IsSettingMove==true){
            GameObject.Find(Panelname).transform.localPosition = Vector3.MoveTowards(GameObject.Find(Panelname).transform.localPosition, 
                new Vector3(0,0,0),Time.deltaTime * speed);
        }
        if (IsSettingMove==false){
            GameObject.Find(Panelname).transform.localPosition = Vector3.MoveTowards(GameObject.Find(Panelname).transform.localPosition, 
                new Vector3(0, Pos, 0) , Time.deltaTime * speed);
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
        Pos = 1200;
        Panelname = "Setting";
        BtnClickSound.IsBtnClick = true;
        settingpanel.SetActive(true);
        IsSettingMove = true;
    }
    public void ClosedBtnOnClick()
    {
        BtnClickSound.IsBtnClick = true;
        Invoke("deley", 1.5f);
        IsSettingMove = false;
    }
    public void ReCordBtnOnClick()
    {
        Pos = 1100;
        Panelname = "ReCordUI";
        BtnClickSound.IsBtnClick = true;
        settingpanel.SetActive(true);
        IsSettingMove = true;
        GameObject.Find("ButtonManager").GetComponent<GameSelectScript>().ReCordButton();
    }
    public void DeveloperBtnOnclick()
    {
        Pos = 1100;
        Panelname = "DeveloperUI";
        BtnClickSound.IsBtnClick = true;
        settingpanel.SetActive(true);
        IsSettingMove = true;
        GameObject.Find("ButtonManager").GetComponent<GameSelectScript>().DeveloperButton();
    }
    public void ExplainBtnOnclick()
    {
        Pos = 1100;
        Panelname = "ExUI";
        BtnClickSound.IsBtnClick = true;
        settingpanel.SetActive(true);
        IsSettingMove = true;
        GameObject.Find("ButtonManager").GetComponent<GameSelectScript>().ExPlainFunc();
    }
    void deley()
    {
        settingpanel.SetActive(false);
    }
}
