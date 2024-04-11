using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkpiints : MonoBehaviour
{
    [SerializeField]
    private GameObject timer;

    public bool isFinishLine = false;
    public static bool check = false;


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
            }
        }
        if (collision.CompareTag("Player") && isFinishLine == false)
        {
            
            check = true;
        }
    }
}
