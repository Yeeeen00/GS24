using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("AI_maingame");
    }
    public void ExitMenu()
    {
        SceneManager.LoadScene("GameSelectScene");
    }
}