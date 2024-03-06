using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceTimeUIHandler : MonoBehaviour
{

    Text timeText;

    float lastRaceTimeUpdate = 0;

    private void Awake()
    {
        timeText = GetComponent<Text>();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UpdateTimeCO());
    }


    IEnumerator UpdateTimeCO()
    {
        
        while (true) {
            float raceTime = 0;

            if (lastRaceTimeUpdate != raceTime)
            {
                timeText.text = raceTime.ToString("00");
                lastRaceTimeUpdate = raceTime;
            }

            yield return new WaitForSeconds(0.1f);
        }
    }
    
}
