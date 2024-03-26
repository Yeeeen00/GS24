using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameSelectScript : MonoBehaviour
{
    GameObject clickBtnObject;
    static Vector3 vector;
    public List<GameObject> GameBtn = new List<GameObject>();
    static int arrnum = 0;
    bool Isrigthmove;
    bool Isleftmove;
    static int Gamecount = 0;
    private void Start()
    {
        if (Gamecount >= 1){
            GameObject.Find("GameIconBtn").transform.position=vector;
        }
        Gamecount++;
    }
    public void StartBtnclick()
    {
        BtnClickSound.IsBtnClick = true;
        if(arrnum==0) SceneManager.LoadScene("Ai_gamestart");
        //if(arrnum==1)
        if(arrnum==2) SceneManager.LoadScene("Level01");
        if(arrnum==3) SceneManager.LoadScene("GomulgaWars");
        if(arrnum==4) SceneManager.LoadScene("Racing");
        if(arrnum==5) SceneManager.LoadScene("BIBIMBAB");
        //if(arrnum==6)
        if(arrnum==7) SceneManager.LoadScene("BlockCode");
    }
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
                if(clickBtnObject.name =="CA")
                {
                    SceneManager.LoadScene("Level01");
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        GameBtn[arrnum].transform.transform.localScale = new Vector3(1.7f, 1.7f);
        vector = GameObject.Find("GameIconBtn").transform.position;
        if (GameObject.Find("GameIconBtn").transform.position.x > -2500) { Isrigthmove = true; }
        if (GameObject.Find("GameIconBtn").transform.position.x <= -2500) { Isrigthmove = false; }
        if (GameObject.Find("GameIconBtn").transform.position.x < 500) { Isleftmove = true; }
        if (GameObject.Find("GameIconBtn").transform.position.x >= 500) { Isleftmove = false; }
        if (Input.GetKeyDown(KeyCode.RightArrow)) Right();
        if (Input.GetKeyDown(KeyCode.LeftArrow)) Left();
    }
}
