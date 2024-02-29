using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public int Score;
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int scoreSum(int s)
    {
        //s = 100 - s; / 만약 시간 값을 보낼 시
        Score += s;
        return Score;
    }
    public void showScore()
    {
        text.text = Score.ToString();
    }
}
