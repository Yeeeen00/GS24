using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GO_ButtonManager : MonoBehaviour
{
    public void OnReStartBtnOnoClick()
    {
        GO_PlayerScript.P_num = 0;
        SceneManager.LoadScene("GomulgaWars");
    }
}
