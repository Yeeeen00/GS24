using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI ScoreText;
    GameData gameData;

    private void Awake()
    {
        ScoreText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (gameData == null)
            gameData = FindObjectOfType<GameData>();

        string Score = gameData.Score.ToString("0000");
        ScoreText.text = Score;
    }
}
