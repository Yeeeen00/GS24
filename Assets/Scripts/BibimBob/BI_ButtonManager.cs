using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BI_ButtonManager : MonoBehaviour
{
    [SerializeField] List<GameObject> list = new List<GameObject>();
    [SerializeField]List<GameObject> Sauce = new List<GameObject>();
    [SerializeField] List<GameObject> _Rice = new List<GameObject>();
    string BtnDuplicationClickCheck;
    string ObjName;
    string ObjTag;
    List<GameObject> ChangeList;
    int _count = 0;
    int Count=0;
    public static int Point = 0;
    bool BtnClickcheck = false;
    bool check=true;



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
    private void Reset()
    {
        _count = 0;
        check = true;
        BtnDuplicationClickCheck="?";
        ObjName="?";
        ObjTag="?";
    }
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
        Reset();
        if (Count == 0)
        {
            MakeRice.SetActive(false);
            Gomyung.SetActive(true);
            BtnClickcheck = false;
            Count++;
        }
        else if (Count == 1)
        {
            Gomyung.SetActive(false) ;
            MakeSauce.SetActive(true);
            BtnClickcheck = false;
            ChangeList = Sauce;
            Count++;
        }
    }
    private void Start()
    {
        ChangeList = _Rice;
    }
    private void Update()
    {
        if(BtnClickcheck == true)
        {
            NextBtn.SetActive(true);
        }
        if(BtnClickcheck ==false)
        { NextBtn.SetActive(false); }
    }
    public void BtnOnClick()
    {
        BtnClickcheck = true;
        GameObject clickBtnObject = EventSystem.current.currentSelectedGameObject;
        if (check == true){
            if (_count >= 1){
                if (clickBtnObject.tag != ObjTag){
                    GameObject.Find(ObjName).SetActive(false);
                }
            }
        }
        if (clickBtnObject.tag != BtnDuplicationClickCheck){
            foreach (GameObject go in ChangeList){
                if (go.tag == clickBtnObject.tag){
                    go.SetActive(true);
                    BtnDuplicationClickCheck = clickBtnObject.tag;
                    ObjTag = go.tag;
                    ObjName = go.name;
                    check = true;
                    _count++;
                }
            }
        }
        else if (clickBtnObject.tag == BtnDuplicationClickCheck){
            foreach (GameObject go in ChangeList)
            {
                if (go.tag == clickBtnObject.tag){
                    go.SetActive(false);
                    check = false;
                    BtnDuplicationClickCheck = "NULL";
                }
            }
        }
        
    }
    public void Btn()
    {
        BtnClickcheck = true;
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
