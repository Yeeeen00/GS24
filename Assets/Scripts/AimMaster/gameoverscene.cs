using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameoverscene : MonoBehaviour
{
    private TextMeshProUGUI scoretext;
    private TextMeshProUGUI accurayratetext;

    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI newRecordText;
    public static int AIM_SaveScore = 0;
    public static float AIM_accuracyRateScore = 0;

    // Start is called before the first frame update
    void Start()
    {

        scoretext = GameObject.Find("score").GetComponent<TextMeshProUGUI>();
        accurayratetext = GameObject.Find("accurayrate").GetComponent<TextMeshProUGUI>();


        int score = MovinTarget.score;
        float accurayrate = MovinTarget.accuracyRate;
        if (score > AIM_SaveScore)
            AIM_SaveScore = score;
        if (MovinTarget.accuracyRate > AIM_accuracyRateScore)
            AIM_accuracyRateScore = accurayrate;
        scoretext.text = "����: " + score.ToString();
        accurayratetext.text = "���߷�: " + accurayrate.ToString("F1") + "%";
    }

    public void GotoMain()
    {
        SceneManager.LoadScene("Ai_gamestart");
        MovinTarget.score = 0;
        MovinTarget.accuracyRate = 0.0f;
    }

    public void ReStart()
    {
        SceneManager.LoadScene("AI_maingame");
        MovinTarget.score = 0;
        MovinTarget.accuracyRate = 0.0f;
;    }

    // Update is called once per frame
    void Update()
    {


    }
}
