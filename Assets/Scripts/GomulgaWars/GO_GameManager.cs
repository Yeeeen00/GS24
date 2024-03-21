using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GO_GameManager : MonoBehaviour
{
    public GameObject SucsesImage;
    public GameObject SucsesPanel;
    public GameObject GameOverImage;
    public GameObject GameOverPanel;
    public GameObject StopImage;
    public GameObject StopPanel;
    public Text[] Stagetext;
    public AudioClip GameOverSound;
    public static int Stage = 0;
    public static bool BGMStop;
    AudioSource GameAudio;
    private bool Isclear = true;
    public static int Escbtncheck = 0;
    private void Start()
    {
        Time.timeScale = 1;
        GameAudio = GetComponent<AudioSource>();
        Stagetext[0].text = Stage.ToString() + " stage";
        Stagetext[1].text = Stage.ToString() + " stage";
        Stagetext[2].text = Stage.ToString() + " stage";
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyUp(KeyCode.Escape)) {
            if (Escbtncheck==0){
                StopPanel.SetActive(true);
                StopImage.SetActive(true);
                BGMStop = true;
                Time.timeScale = 0;
                Escbtncheck++;
            }
            else if (Escbtncheck==1) {
                BtnClickSound.IsBtnClick = true;
                Time.timeScale = 1;
                BGMStop = false;
                StopPanel.SetActive(false);
                StopImage.SetActive(false);
                Escbtncheck = 0;
            }
        }
        if (Isclear == true){
            if (GameObject.FindGameObjectWithTag("Enemy") == null && GameObject.FindGameObjectWithTag("Enemy2") == null){
                SucsesImage.SetActive(true);
                SucsesPanel.SetActive(true);
                Isclear = false;
            }
            if (GameObject.FindGameObjectWithTag("Player") == false){
                if (Stage == 1) GO_PlayerScript.P_num = 0;
                Stage -= 1;
                GameOverImage.SetActive(true);
                GameOverPanel.SetActive(true);
                GameAudio.PlayOneShot(GameOverSound);
                Isclear= false;
            }
        }
    }
}
