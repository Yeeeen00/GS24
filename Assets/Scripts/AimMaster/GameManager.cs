using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float gameTime = 30f; // ���� �ð� (��)
    private float timeRemaining;  // ���� �ð�
    private bool isGameOver = false;

    public TextMeshProUGUI timeText;

    void Start()
    {
        timeRemaining = gameTime;
        UpdateTimeText();
    }

    void Update()
    {
        if (!isGameOver)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimeText();

            if (timeRemaining <= 0)
            {
                EndGame();
            }
        }
    }
    void UpdateTimeText()
    {
        if (timeText != null)
        {
            timeText.text = "Time: " + Mathf.Max(0, Mathf.FloorToInt(timeRemaining)).ToString();
        }
    }

    void EndGame()
    {
        SceneManager.LoadScene("gameover");
    }

}
