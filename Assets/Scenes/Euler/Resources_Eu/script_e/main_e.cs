using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static System.Net.Mime.MediaTypeNames;

public class main_e : MonoBehaviour
{
    int num = 0;
    [SerializeField] private List<UnityEngine.UI.Image> p_image = new List<UnityEngine.UI.Image>();

    void Start()
    {
        p_image[1].gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (num == 1)
            {
                p_image[num].gameObject.SetActive(false);
                num--;
                p_image[num].gameObject.SetActive(true);
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (num == 0)
            {
                p_image[num].gameObject.SetActive(false);
                num++;
                p_image[num].gameObject.SetActive(true);
            }
        }
        else if (Input.GetKey(KeyCode.Return))
        {
            if (num == 0)
            {
                SceneManager.LoadScene("Euler_t");
            }
            else if (num == 1)
            {
                Quit();
            }
        }
    }

    void Quit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}