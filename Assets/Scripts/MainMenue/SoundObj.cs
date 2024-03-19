using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundObj : MonoBehaviour
{
    public GameObject Prefab1;
    public GameObject Prefab2;
    public static int GameCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (GameCount == 0)
        {
            Instantiate(Prefab1);
            Instantiate(Prefab2);
            GameCount++;
        }
    }
}
