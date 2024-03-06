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

    // Start is called before the first frame update
    void Start()
    {

        scoretext = GameObject.Find("score").GetComponent<TextMeshProUGUI>();
        accurayratetext = GameObject.Find("accurayrate").GetComponent<TextMeshProUGUI>();


        int score = MovinTarget.score;
        float accurayrate = MovinTarget.accuracyRate;

        scoretext.text = "Á¡¼ö: " + score.ToString();
        accurayratetext.text = "¸íÁß·ü: " + accurayrate.ToString("F1") + "%";
    }

    public void GotoMain()
    {
        SceneManager.LoadScene("gamestart");
        MovinTarget.score = 0;
        MovinTarget.accuracyRate = 0.0f;
    }

    public void ReStart()
    {
        SceneManager.LoadScene("maingame");
        MovinTarget.score = 0;
        MovinTarget.accuracyRate = 0.0f;
;    }

    // Update is called once per frame
    void Update()
    {


    }
}
