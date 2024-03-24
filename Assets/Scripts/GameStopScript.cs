using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStopScript : MonoBehaviour
{
    int Escbtncheck = 0;
    public GameObject StopPanel;
    public GameObject StopImage;
    public void ExitBtn()
    {
        BtnClickSound.IsBtnClick = true;
        SceneManager.LoadScene("GameSelectScene");
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update() 
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (Escbtncheck == 0)
            {
                StopPanel.SetActive(true);
                StopImage.SetActive(true);
                Time.timeScale = 0;
                Escbtncheck++;
            }
            else if (Escbtncheck == 1)
            {
                BtnClickSound.IsBtnClick = true;
                Time.timeScale = 1;
                StopPanel.SetActive(false);
                StopImage.SetActive(false);
                Escbtncheck = 0;
            }
        }
    }
}
