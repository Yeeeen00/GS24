using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Timer : MonoBehaviour
{

    [Header("Component")]
    public TextMeshProUGUI timeText;

    [Header("Timer Settings")]
    public float currentTime;

    public GameObject startLine;

    bool isStarted = false;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (isStarted == true)
        {
            currentTime += Time.deltaTime;
            timeText.text = currentTime.ToString("0.000");
        }
    }

    public void raceStart()
    {
        isStarted = true;
    }

    public void raceEnd()
    {
        isStarted=false;
    }
}
