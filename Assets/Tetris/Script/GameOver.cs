using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Button Btn_Restart;
    public static int Te_SaveScore = 0;
    public GameData GameData;
    void Start()
    {
        Btn_Restart.onClick.AddListener(Reset);
    }

    void Reset()
    {
        if(GameData.Score>Te_SaveScore) {
            Te_SaveScore=GameData.Score;
        }
        SceneManager.LoadScene("Tetris");
    }
}