using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DevleoperMin : MonoBehaviour
{
    private float speed = 3.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 1 * speed * Time.deltaTime, 0);
        if(transform.localPosition.y>2154)
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
