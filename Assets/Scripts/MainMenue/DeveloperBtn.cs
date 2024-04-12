using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeveloperBtn : MonoBehaviour
{
    public void developerBtnOnclick()
    {
        BtnClickSound.IsBtnClick=true;
        SceneManager.LoadScene("Developerpage");
    }
}
