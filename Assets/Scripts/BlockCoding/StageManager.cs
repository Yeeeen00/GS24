using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public StageDatabase StaDB;
    // Start is called before the first frame update
    void Awake()
    {
        SetStage();
    }

    // Update is called once per frame
    void Update()
    {

    }





    public void SetStage()
    {
        //1
        StaDB.stg[1].allocBlocks[0] = new BlockClone();
        StaDB.stg[1].allocBlocks[0].Name = "반복문조건";
        StaDB.stg[1].allocBlocks[0].index = 5;

        StaDB.stg[1].allocBlocks[1] = new BlockClone();
        StaDB.stg[1].allocBlocks[1].Name = "행동하기";
        StaDB.stg[1].allocBlocks[1].index = 140;

        StaDB.stg[1].allocBlocks[2] = new BlockClone();
        StaDB.stg[1].allocBlocks[2].Name = "행동하기";
        StaDB.stg[1].allocBlocks[2].index = 150;

        StaDB.stg[1].allocBlocks[3] = new BlockClone();
        StaDB.stg[1].allocBlocks[3].Name = "반복문끝";
        StaDB.stg[1].allocBlocks[3].index = 0;

        StaDB.stg[1].allocBlocks[4] = new BlockClone();
        StaDB.stg[1].allocBlocks[4].Name = "끝";
        StaDB.stg[1].allocBlocks[4].index = 0;

        //2
    }
}
