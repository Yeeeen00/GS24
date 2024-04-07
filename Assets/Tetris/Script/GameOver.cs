using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Button Btn_Restart;
    void Start()
    {
        Btn_Restart.onClick.AddListener(Reset);
    }

    void Reset()
    {
        SceneManager.LoadScene("Tetris");
    }
}