using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Newtonsoft.Json.Linq;

public class MovinTarget : MonoBehaviour
{
    public float XmoveRange;
    public float YmoveRange;
    public int scorePerHit = 10;
    public static float accuracyRate = 0f;
    public static int score = 0;

    private int clickCount = 0;
    private bool isGameActive = true; // 게임 활성화 여부

    private TextMeshProUGUI scoreText;
    private TextMeshProUGUI accuracyRateText;
    private GameObject gameOverPanel;

    void Start()
    {
        // UI TextMeshProUGUI 컴포넌트 찾기
        scoreText = GameObject.Find("scoreText").GetComponent<TextMeshProUGUI>();
        accuracyRateText = GameObject.Find("accuracyRateText").GetComponent<TextMeshProUGUI>();

        if (scoreText == null || accuracyRateText == null || gameOverPanel == null)
        {
            Debug.LogError("UI Text 컴포넌트를 찾을 수 없습니다!");
        }

        SetRandomPosition();
        UpdateScoreText();
    }

    void Update()
    {
        if (isGameActive && Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            clickCount++;

            // Raycast 디버깅
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.gameObject.name + "을 클릭했습니다.");
                score += scorePerHit;
            }

            // 명중률 계산
            float hitRate = clickCount > 0 ? ((float)score / clickCount) / scorePerHit : 0f;
            accuracyRate = Mathf.Min(hitRate * 100f, 100f); // 최대값을 100으로 제한

            UpdateScoreText();
            SetRandomPosition();
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null && accuracyRateText != null)
        {
            scoreText.text = "점수: " + score.ToString();
            accuracyRateText.text = "명중률: " + accuracyRate.ToString("F1") + "%";
        }
    }

    void SetRandomPosition()
    {
        float randomX = UnityEngine.Random.Range(-XmoveRange, XmoveRange);
        float randomY = UnityEngine.Random.Range(-YmoveRange, YmoveRange);

        transform.position = new Vector3(randomX, randomY, 0f);
    }

    public void EndGame()
    {
        SceneManager.LoadScene("gameover");
    }
}