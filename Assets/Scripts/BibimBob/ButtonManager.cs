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
                if (clickBtnObject.name == "고사리")
                {
                    GoSari.SetActive(true);
                }
                if (clickBtnObject.name == "돼지고기")
                {
                    Pork.SetActive(true);
                }
                if (clickBtnObject.name == "소고기")
                {
                    Beef.SetActive(true);
                }
                if (clickBtnObject.name == "각설탕")
                {
                    Sugar.SetActive(true);
                }
                if (clickBtnObject.name == "시금치")
                {
                    Spinach.SetActive(true);
                }
                if (clickBtnObject.name == "당근")
                {
                    Carrot.SetActive(true);
                }
                if (clickBtnObject.name == "부추")
                {
                    Boochu.SetActive(true);
                }
                if (clickBtnObject.name == "김치")
                {
                    Kimchi.SetActive(true);
                }
                if (clickBtnObject.name == "파맛첵스")
                {
                    GreenOnionChecks.SetActive(true);
                }
                if (clickBtnObject.name == "애호박")
                {
                    LittlePumpkin.SetActive(true);
                }
            }
        }
    }
}
