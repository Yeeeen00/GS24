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
    private bool isGameActive = true; // ���� Ȱ��ȭ ����

    private TextMeshProUGUI scoreText;
    private TextMeshProUGUI accuracyRateText;
    private GameObject gameOverPanel;

    void Start()
    {
        // UI TextMeshProUGUI ������Ʈ ã��
        scoreText = GameObject.Find("scoreText").GetComponent<TextMeshProUGUI>();
        accuracyRateText = GameObject.Find("accuracyRateText").GetComponent<TextMeshProUGUI>();

        if (scoreText == null || accuracyRateText == null || gameOverPanel == null)
        {
            Debug.LogError("UI Text ������Ʈ�� ã�� �� �����ϴ�!");
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

            // Raycast �����
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.gameObject.name + "�� Ŭ���߽��ϴ�.");
                score += scorePerHit;
            }

            // ���߷� ���
            float hitRate = clickCount > 0 ? ((float)score / clickCount) / scorePerHit : 0f;
            accuracyRate = Mathf.Min(hitRate * 100f, 100f); // �ִ밪�� 100���� ����

            UpdateScoreText();
            SetRandomPosition();
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null && accuracyRateText != null)
        {
            scoreText.text = "����: " + score.ToString();
            accuracyRateText.text = "���߷�: " + accuracyRate.ToString("F1") + "%";
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