using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
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
    [SerializeField] List<GameObject> MakeRice = new List<GameObject>();
    [SerializeField] List<GameObject> Gomyung = new List<GameObject>();

    public void NextBtnOnclick()
    {
        foreach (GameObject go in MakeRice) {
            go.SetActive(false);
        }
        foreach (GameObject go in Gomyung) {  go.SetActive(true); }
    }
    public void NextStage1()
    {
        SceneManager.LoadScene("MakeGoMyung");
    }

    public void Rice()
    {
        SavedData.Ins.curRice = global::Rice.WhiteRice;
        rice.color = new Color(1f, 1f, 1f, .1f);
    }
    public void KongRice()
    {
        SavedData.Ins.curRice = global::Rice.BeanRice;
        rice.color = new Color(1f, 0.92f, 0.016f, .1f);
    }
    public void BrownRice()
    {
        SavedData.Ins.curRice = global::Rice.HyunMeRice;
        rice.color = new Color(1f, 0f, 1f, .1f);
    }

    [SerializeField] List<GameObject> list = new List<GameObject>();
    public void Btn()
    {
        GameObject clickBtnObject = EventSystem.current.currentSelectedGameObject;
        foreach (GameObject go in list)
        {
            if (go == clickBtnObject)
            {
                if (clickBtnObject.name == "��縮")
                {
                    GoSari.SetActive(true);
                }
                if (clickBtnObject.name == "�������")
                {
                    Pork.SetActive(true);
                }
                if (clickBtnObject.name == "�Ұ��")
                {
                    Beef.SetActive(true);
                }
                if (clickBtnObject.name == "������")
                {
                    Sugar.SetActive(true);
                }
                if (clickBtnObject.name == "�ñ�ġ")
                {
                    Spinach.SetActive(true);
                }
                if (clickBtnObject.name == "���")
                {
                    Carrot.SetActive(true);
                }
                if (clickBtnObject.name == "����")
                {
                    Boochu.SetActive(true);
                }
                if (clickBtnObject.name == "��ġ")
                {
                    Kimchi.SetActive(true);
                }
                if (clickBtnObject.name == "�ĸ�ý��")
                {
                    GreenOnionChecks.SetActive(true);
                }
                if (clickBtnObject.name == "��ȣ��")
                {
                    LittlePumpkin.SetActive(true);
                }
            }
        }
    }
}
