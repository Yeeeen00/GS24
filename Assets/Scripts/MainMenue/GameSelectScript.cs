using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameSelectScript : MonoBehaviour
{
    GameObject clickBtnObject;
    public List<GameObject> GameBtn = new List<GameObject>();
    int arrnum = 0;
    bool Isrigthmove;
    bool Isleftmove;
    // Start is called before the first frame update
    void Right()
    {
        if (Isrigthmove != false)
        {
            GameObject.Find("GameIconBtn").transform.position += new Vector3(-500, 0, 0);
            GameBtn[arrnum].transform.transform.localScale = new Vector3(1, 1);
            arrnum++;
        }
    }
    void Left()
    {
        if (Isleftmove != false)
        {
            GameObject.Find("GameIconBtn").transform.position += new Vector3(500, 0, 0);
            GameBtn[arrnum].transform.transform.localScale = new Vector3(1, 1);
            arrnum--;
        }
    }
    public void RightArrowBtn()
    {
        BtnClickSound.IsBtnClick = true;
        if (Isrigthmove != false)
        {
            GameObject.Find("GameIconBtn").transform.position += new Vector3(-500, 0, 0);
            GameBtn[arrnum].transform.transform.localScale = new Vector3(1, 1);
            arrnum++;
        }
    }
    public void LeftArrowBtn()
    {
        BtnClickSound.IsBtnClick = true;
        if (Isleftmove != false)
        {
            GameObject.Find("GameIconBtn").transform.position += new Vector3(500, 0, 0);
            GameBtn[arrnum].transform.transform.localScale = new Vector3(1, 1);
            arrnum--;
        }
    }
    public void GameBtnOnClick()
    {
        BtnClickSound.IsBtnClick = true;
        clickBtnObject = EventSystem.current.currentSelectedGameObject;
        foreach (GameObject go in GameBtn)
        {
            if (go.name == clickBtnObject.name)
            {
                if (clickBtnObject.name == "GO")
                {
                    SceneManager.LoadScene("GomulgaWars");
                }
                if (clickBtnObject.name == "AIM")
                {
                    SceneManager.LoadScene("Ai_gamestart");
                }
                if (clickBtnObject.name == "BLE")
                {
                    SceneManager.LoadScene("BlockCode");
                }
                if (clickBtnObject.name == "WI")
                {
                    SceneManager.LoadScene("Racing");
                }
                if (clickBtnObject.name == "BI")
                {
                    SceneManager.LoadScene("BIBIMBAB");
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        GameBtn[arrnum].transform.transform.localScale = new Vector3(1.7f, 1.7f);
        if (GameObject.Find("GameIconBtn").transform.position.x > -2500) { Isrigthmove = true; }
        if (GameObject.Find("GameIconBtn").transform.position.x <= -2500) { Isrigthmove = false; }
        if (GameObject.Find("GameIconBtn").transform.position.x < 500) { Isleftmove = true; }
        if (GameObject.Find("GameIconBtn").transform.position.x >= 500) { Isleftmove = false; }
        if (Input.GetKeyDown(KeyCode.RightArrow)) Right();
        if (Input.GetKeyDown(KeyCode.LeftArrow)) Left();
    }
}
