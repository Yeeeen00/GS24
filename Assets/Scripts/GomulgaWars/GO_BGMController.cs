using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_BGMController : MonoBehaviour
{
    AudioSource BGM;
    void Start()
    {
        BGM = GetComponent<AudioSource>();
        BGM.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (GO_GameManager.BGMStop == true){
            BGM.Pause();
        }
        if (GO_GameManager.BGMStop == false)
        {
            BGM.UnPause();
        }
    }
}
