using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public float Score;
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float scoreSum(float s)
    {
        s = 100 - s;
        Score += s;
        showScore();
        return Score;
    }
    public void showScore()
    {
        text.text = Mathf.Round(Score).ToString();
    }
}
