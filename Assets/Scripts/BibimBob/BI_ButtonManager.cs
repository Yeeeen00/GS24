using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BI_ButtonManager : MonoBehaviour
{
    [SerializeField] List<GameObject> GomyungList = new List<GameObject>();
    [SerializeField] List<GameObject> Sauce = new List<GameObject>();
    [SerializeField] List<GameObject> _Rice = new List<GameObject>();
    List<GameObject> ChangeList;
    string BtnDuplicationClickCheck;
    bool SauceMake = true;
    bool isRiceMaking = true;
    int Count = 0;
    public int Point = 0;
    bool BtnClickcheck = false;
    bool check = true;
    public GameObject NextBtn;
    public GameObject MakeRice;
    public GameObject Gomyung;
    public GameObject MakeSauce;
    public GameObject EGG;
    private bool[] sauceStick = new bool[3] { false, false, false };
    private bool[] riceStick = new bool[3] { false, false, false };
    public void ContinueBtnClick()
    {
        BtnClickSound.IsBtnClick = true;
        SceneManager.LoadScene("BIBIMBAB");
    }
    public void ExitMainMenu()
    {
        BtnClickSound.IsBtnClick = true;
        SceneManager.LoadScene("GameSelectScene");
    }
    private void Reset()
    {
        check = true;
        BtnDuplicationClickCheck = "?";
    }
    #region string to index
    private int RiceToIndex(string str)
    {
        if (str == "쌀밥버튼") return 0;
        if (str == "현미밥버튼") return 1;
        if (str == "콩밥버튼") return 2;
        else return -1;
    }
    private int SauceToIndex(String str)
    {
        if (str == "고추장") return 0;
        if (str == "불닭소스") return 1;
        if (str == "와사비") return 2;
        else return -1;
    }
    private int SauceToScore(string str)
    {
        if (str == "고추장") return 1;
        if (str == "불닭소스") return -1;
        if (str == "와사비") return -1;
        else return 0;
    }

    private string IntToSauce(int i)
    {
        if (i == 0) return "고추장";
        if (i == 1) return "불닭소스";
        if (i == 2) return "와사비";
        else return "";
    }
    #endregion
    public void NextBtnOnclick()
    {
        Reset();
        if (Count == 0)
        {
            isRiceMaking = false;
            MakeRice.SetActive(false);
            Gomyung.SetActive(true);
            BtnClickcheck = false;
            ChangeList = GomyungList;
            SauceMake = true;
            Count++;
        }
        else if (Count == 1)
        {
            Gomyung.SetActive(false);
            MakeSauce.SetActive(true);
            EGG.SetActive(true);
            BtnClickcheck = false;
            ChangeList = Sauce;
            SauceMake = false;
            Count++;
        }
        else if (Count == 2)
        {
            Count++;
        }
        if (Count >= 3)
        {
            if (Point < 5)
            {
                SceneManager.LoadScene("BibimbabFail");
            }
        }
        if (Point > 5)
        {
            SceneManager.LoadScene("BibimbabEnding");
        }
    }
    private void Start()
    {
        ChangeList = _Rice;
    }
    private void Update()
    {
        if (BtnClickcheck == true)
        {
            NextBtn.SetActive(true);
        }
        if (BtnClickcheck == false)
        { NextBtn.SetActive(false); }
    }

    public void SauceFunc(string sauce)
    { //  name : 고추장1 or 와사비-1 or 불닭소스-1
        Debug.Log(sauce);
        bool isTurnOn = false;
        for (int i = 0; i < 3; i++)
        {
            if (i == SauceToIndex(sauce))
            {
                if (sauceStick[i])
                {
                    Point -= SauceToScore(sauce);
                    sauceStick[i] = false;
                }
                else
                {
                    isTurnOn = true;
                    Point += SauceToScore(sauce);
                    sauceStick[i] = true;
                }
            }
        }
        if (isTurnOn)
        {
            for (int i = 0; i < 3; i++)
            {
                if (i != SauceToIndex(sauce) && sauceStick[i])
                {
                    Point -= SauceToScore(IntToSauce(i));
                    sauceStick[i] = false;
                }
            }
        }
        for (int i = 0; i < 3; i++)
        {
            Sauce[i].SetActive(sauceStick[i]);
        }
    }

    private void MakeRiceFunc(string str)
    {
        int index = RiceToIndex(str);
        bool isTurnOn = false;
        if (!riceStick[index])
        {
            isTurnOn = true;
            riceStick[index] = true;
        }
        else riceStick[index] = false;

        if (isTurnOn)
        {
            for (int i = 0; i < 3; i++)
            {
                if (i == index) continue;
                riceStick[i] = false;
            }
        }

        for (int i = 0; i < 3; i++)
        {
            _Rice[i].SetActive(riceStick[i]);
        }
    }
    public void BtnOnClick()
    {
        BtnClickcheck = true;
        GameObject clickBtnObject = EventSystem.current.currentSelectedGameObject;
        Debug.Log(clickBtnObject.name);
        if (isRiceMaking) MakeRiceFunc(clickBtnObject.name);
        if (SauceMake != true)
        {
            if (check == true)
            {
                SauceFunc(clickBtnObject.name);
            }
        }
        if (clickBtnObject.tag != BtnDuplicationClickCheck && SauceMake && !isRiceMaking)
        {
            foreach (GameObject go in ChangeList)
            {
                if (go.tag == clickBtnObject.tag)
                {
                    go.SetActive(true);
                    if (go.name == "시금치") { Point += 1; }
                    if (go.name == "돼지고기") { Point += -1; }
                    if (go.name == "소고기") { Point += 1; }
                    if (go.name == "각설탕") { Point += -1; }
                    if (go.name == "김치") { Point += -1; }
                    if (go.name == "고사리") { Point += 1; }
                    if (go.name == "파맛첵스") { Point += -1; }
                    if (go.name == "애호박") { Point += 1; }
                    if (go.name == "부추") { Point += -1; }
                    if (go.name == "당근") { Point += 1; }
                    BtnDuplicationClickCheck = clickBtnObject.tag;
                    check = true;
                }
            }
        }
        else if (clickBtnObject.tag == BtnDuplicationClickCheck && SauceMake && !isRiceMaking)
        {
            foreach (GameObject go in ChangeList)
            {
                if (go.tag == clickBtnObject.tag)
                {
                    Debug.Log("is");
                    if (go.name == "시금치") { Point -= 1; }
                    if (go.name == "돼지고기") { Point -= -1; }
                    if (go.name == "소고기") { Point -= 1; }
                    if (go.name == "각설탕") { Point -= -1; }
                    if (go.name == "김치") { Point -= -1; }
                    if (go.name == "고사리") { Point -= 1; }
                    if (go.name == "파맛첵스") { Point -= -1; }
                    if (go.name == "애호박") { Point -= 1; }
                    if (go.name == "부추") { Point -= -1; }
                    if (go.name == "당근") { Point -= 1; }
                    go.SetActive(false);
                    check = false;
                    BtnDuplicationClickCheck = "?";
                }
            }
        }
        //소스 점수

    }

}
