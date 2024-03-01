using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_GameManager : MonoBehaviour
{
    public GameObject SucsesImage;
    public GameObject GameOverImage;
    public GameObject GameOverPanel;
    public AudioClip GameOverSound;
    AudioSource GameAudio;
    private bool Isclear = true;

    private void Start()
    {
        GameAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update(){
        if (Isclear == true){
            if (GameObject.FindGameObjectWithTag("Enemy") == null && GameObject.FindGameObjectWithTag("Enemy2") == null){
                SucsesImage.SetActive(true);
                Isclear = false;
            }
            if (GameObject.FindGameObjectWithTag("Player") == false){
                GameOverImage.SetActive(true);
                GameOverPanel.SetActive(true);
                GameAudio.PlayOneShot(GameOverSound);
                Isclear= false;
            }
        }
    }
}
