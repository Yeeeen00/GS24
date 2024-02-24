using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BI_ButtonManager : MonoBehaviour
{
    [SerializeField] List<GameObject> list = new List<GameObject>();
    [SerializeField] List<GameObject> SauceBtn = new List<GameObject>();
    [SerializeField]List<GameObject> Sauce=new List<GameObject>();
    int Count=0;
    public static int Point = 0;
    bool check=false;
    public GameObject NextBtn;
    public GameObject GoSari;
    public GameObject Beef;
    public GameObject Pork;
    public GameObject Sugar;
    public GameObject Spinach;
    public GameObject Carrot;
    public GameObject Boochu;
    public GameObject Kimchi;
    public GameObject GreenOnionChecks;
    public GameObject LittlePumpkin;
    public Image rice;
    public GameObject MakeRice;
    public GameObject Gomyung;
    public GameObject MakeSauce;
    
    public void PointCheck()
    {
        if(Point >= 5)
        {

        }
        else
        {

        }
    }
    public void NextBtnOnclick()
    {
        if(Count == 1)
        {
            Gomyung.SetActive(false) ;
            MakeSauce.SetActive(true);
            check = false;
            Count++;
        }
        if (Count == 0)
        {
            MakeRice.SetActive(false);
            Gomyung.SetActive(true);
            check = false;
            Count++;
        }
    }
    private void Start()
    {
        
    }
    private void Update()
    {
        if(check==true)
        {
            NextBtn.SetActive(true);
        }
        if(check==false)
        { NextBtn.SetActive(false); }
    }

    public void Rice()
    {
        SavedData.Ins.curRice = global::Rice.WhiteRice;
        rice.color = new Color(1f, 1f, 1f, .1f);
        check = true;
    }
    public void KongRice()
    {
        SavedData.Ins.curRice = global::Rice.BeanRice;
        rice.color = new Color(1f, 0.92f, 0.016f, .1f);
        check = true;
    }
    public void BrownRice()
    {
        SavedData.Ins.curRice = global::Rice.HyunMeRice;
        rice.color = new Color(1f, 0f, 1f, .1f);
        check = true;
    }
    public void _SauceBtn() {
        check = true;
        foreach (GameObject go in SauceBtn)
        {
             if(go.gameObject.name=="�Ҵ߼ҽ�")
            {
                foreach (GameObject gu in Sauce)
                {
                    if (gu.gameObject.name == "Sauce")
                    {
                        gu.SetActive(true);
                    }
                }
            }
        }
    }
    public void Btn()
    {
        check = true;
        GameObject clickBtnObject = EventSystem.current.currentSelectedGameObject;
        foreach (GameObject go in list)
        {
            if (go == clickBtnObject)
            {
                if (clickBtnObject.name == "��縮")
                {
                    GoSari.SetActive(true);
                    Point++;
                }
                if (clickBtnObject.name == "�������")
                {
                    Pork.SetActive(true);
                    Point--;
                }
                if (clickBtnObject.name == "�Ұ��")
                {
                    Beef.SetActive(true);
                    Point++;
                }
                if (clickBtnObject.name == "������")
                {
                    Sugar.SetActive(true);
                    Point--;
                }
                if (clickBtnObject.name == "�ñ�ġ")
                {
                    Spinach.SetActive(true);
                    Point++;
                }
                if (clickBtnObject.name == "���")
                {
                    Carrot.SetActive(true);
                    Point++;
                }
                if (clickBtnObject.name == "����")
                {
                    Boochu.SetActive(true);
                    Point--;
                }
                if (clickBtnObject.name == "��ġ")
                {
                    Kimchi.SetActive(true);
                    Point--;
                }
                if (clickBtnObject.name == "�ĸ�ý��")
                {
                    GreenOnionChecks.SetActive(true);
                    Point--;
                }
                if (clickBtnObject.name == "��ȣ��")
                {
                    LittlePumpkin.SetActive(true);
                    Point++;
                }
            }
        }
    }
}
