using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkpiints : MonoBehaviour
{
    [SerializeField]
    private GameObject timer;
    public GameObject WounjoPanel;
    public GameObject Panel;
    public bool isFinishLine = false;
    public static bool check = false;
    public static float SaveTimer = 100000f;

    public void Start()
    {
        timer = GameObject.Find("TimeManager");
    }

    public void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.CompareTag("Player") && isFinishLine == true)
        {
            timer.GetComponent<Timer>().raceStart();
            if (check == true)
            {
                timer.GetComponent<Timer>().raceEnd();
                WounjoPanel.SetActive(true);
                Panel.SetActive(true);
                Time.timeScale = 0;
                if(timer.GetComponent<Timer>().currentTime < SaveTimer)
                    SaveTimer = timer.GetComponent<Timer>().currentTime;
            }
        }
        if (collision.CompareTag("Player") && isFinishLine == false)
        {
            check = true;
        }
    }
}
