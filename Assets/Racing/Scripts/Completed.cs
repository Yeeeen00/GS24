using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Completed : MonoBehaviour
{
    public Text NewRecordtxt;
    public Text Recordtxt;
    private void Update()
    {
        NewRecordtxt.text = "최고 기록 : " + checkpiints.SaveTimer.ToString("F3");
        Recordtxt.text = "기록 : " + GameObject.Find("TimeManager").GetComponent<Timer>().currentTime.ToString("F3");
    }
    public void ReStartBtn()
    {
        Time.timeScale = 1;
        BtnClickSound.IsBtnClick = true;
        checkpiints.check=false;
        SceneManager.LoadScene("Racing");
    }
}
