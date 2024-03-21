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

    GameObject startLine;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        timeText.text = currentTime.ToString("0.000");
    }
}
