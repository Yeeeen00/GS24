using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] Windows = new GameObject[13];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click(int index)
    {
        for(int i = 0; i < Windows.Length; i++)
        {
            Windows[i].SetActive(false);
        }
        Windows[index].SetActive(true);
    }
}
