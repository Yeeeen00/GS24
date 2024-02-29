using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public BlockSlot Bs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TryStage()
    {
        for(int i = 0; i < Bs.itemList.Count; i++)
        {
            Debug.Log(i + "¹ø : " + Bs.itemList[i].Name + ", " + Bs.itemList[i].index);
        }
            
    }
}
