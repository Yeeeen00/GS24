using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MovinTarget : MonoBehaviour
{
    public float XmoveRange;
    public float YmoveRange;
    public int scorePerHit = 10;

    private int score = 0;
    private int clickCount = 0;
    private float accuracyRate = 0f;

    private TextMeshProUGUI scoreText;
    private TextMeshProUGUI accuracyRateText;

    void Start()
    {
        // UI TextMeshProUGUI 컴포넌트 찾기
        scoreText = GameObject.Find("scoreText").GetComponent<TextMeshProUGUI>();
        accuracyRateText = GameObject.Find("accuracyRateText").GetComponent<TextMeshProUGUI>();

        if (scoreText == null || accuracyRateText == null)
        {
            Debug.LogError("UI Text components not found!");
        }

        SetRandomPosition();
        UpdateScoreText();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            clickCount++;

            // Raycast 디버깅
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Clicked on: " + hit.collider.gameObject.name);
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
        float randomX = Random.Range(-XmoveRange, XmoveRange);
        float randomY = Random.Range(-YmoveRange, YmoveRange);
        transform.position = new Vector3(randomX, randomY, 0f);
    }
}