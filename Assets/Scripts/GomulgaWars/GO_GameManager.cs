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
    AudioSource GameAudio;
    private bool Isclear = true;

    private void Start()
    {
        GameAudio = GetComponent<AudioSource>();
        Stagetext[0].text = Stage.ToString() + " stage";
        Stagetext[1].text = Stage.ToString() + " stage";
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyUp(KeyCode.Escape)) { 
            StopPanel.SetActive(true);
            StopImage.SetActive(true);
            Time.timeScale = 0;
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
