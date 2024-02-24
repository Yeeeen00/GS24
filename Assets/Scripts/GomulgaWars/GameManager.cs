using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject SucsesImage;
    public GameObject GameOverImage;
    private bool Isclear = true;

    // Update is called once per frame
    void Update()
    {
        if (Isclear == true)
        {
            if (GameObject.FindGameObjectWithTag("Enemy") == null && GameObject.FindGameObjectWithTag("Enemy2") == null)
            {
                SucsesImage.SetActive(true);
                Isclear = false;
            }
            if (GameObject.FindGameObjectWithTag("Player") == false)
            {
                GameOverImage.SetActive(true);
                Isclear= false;
            }
        }
    }
}
