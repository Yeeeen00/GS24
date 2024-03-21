using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManiger : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Time.timeScale = 0;
        }


    }
}
