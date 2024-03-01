using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class time : MonoBehaviour
{
    public static bool isCount = false;
    public float second;

    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCount)
        {
            if (second >= 0)
                second -= Time.deltaTime;
            else
            { 
                second = 0;
                TimesUp();
            }

            
            ShowTime();
        }
    }
    public void ShowTime()
    {
        
        text.text = Mathf.Round(second).ToString();
    }
    public void TimesUp()
    {
        Debug.Log("½Ã°£ ³¡");
    }
}
