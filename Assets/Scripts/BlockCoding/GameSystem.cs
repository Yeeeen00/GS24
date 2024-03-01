using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    public BlockSlot Bs;
    public stage[] stages = new stage[5];
    public StageDatabase sDB;
    public score sc;

    public Image StageImg;
    public GameObject Game;
    public GameObject Title;
    //public Animation ani;


    public int round = 0;
    public float second;
    public bool StageisCount = false;
    public bool TF = true;
    public bool StopAni = false;
    // Start is called before the first frame update
    void Start()
    {
        chooseStage();
    }

    // Update is called once per frame
    void Update()
    {
        if (StageisCount) second += Time.deltaTime;
    }

    public void chooseStage()
    {
        for(int i = 0; i <5; i++)
        {
            stages[i] = new stage();
            int num;
            num = UnityEngine.Random.Range(0, 10);
            for (int j =0; j <=i; j++)
            {
                if(stages[j] == sDB.stg[num]) num = UnityEngine.Random.Range(0, 10); break;
            }
            Debug.Log(stages[i]);
            
            stages[i] = sDB.stg[num];
        }
    }
    public void LoadStage()
    {
        StageImg.sprite = stages[round].image;
        Bs.initList();
        time.isCount = true;
        second = 0;
        StageisCount = true;
    }
    public void TryStage()
    {
        time.isCount = false;
        StageisCount = false;

        for (int i = 0; i < Bs.itemList.Count; i++)
        {
            Debug.Log(i + "번 : " + Bs.itemList[i].Name + ", " + Bs.itemList[i].index);
        }
        judgeStage();


    }
    public void judgeStage()
    {
        if (Bs.itemList.Count != 0)
        {
            for (int i = 0; i < Bs.itemList.Count; i++)
            {
                Debug.Log(stages[round].allocBlocks[i].Name + "+" + Bs.itemList[i].Name);
                if (stages[round].allocBlocks[i].Name != Bs.itemList[i].Name || stages[round].allocBlocks[i].index != Bs.itemList[i].index)
                {
                    Debug.Log("안됨");
                    Fail();
                    TF = false;
                    break;
                }
            }
            if (TF) Success();
        }
        else Fail();
    }
    public void Success()
    {
        Debug.Log(sc.scoreSum(second));
        sc.scoreSum(second);

        finish();
        LoadStage();
        time.isCount = true;
    }
    public void Fail()
    {
        finish();
        LoadStage();
        time.isCount = true;

    }
    public void finish()
    {
        if (round + 1 >= 5)
        {
            time.isCount = false;
            StageisCount = false;
            second = 0;

            Game.SetActive(false);
            Title.SetActive(true);
            //알아서 점수랑 연계
        }
        else round++;
    }
    

}
