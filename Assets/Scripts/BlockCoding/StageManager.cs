using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public StageDatabase StaDB;
    // Start is called before the first frame update
    void Awake()
    {
        SetStage1();
        SetStage2();
        SetStage3();
        SetStage4();
        SetStage5();
        SetStage6();
        SetStage7();
        SetStage8();
        SetStage9();
        SetStage10();
       

       
        
    }

    // Update is called once per frame
    void Update()
    {

    }





    public void SetStage1()
    {
        //1
        BlockClone B1 = new BlockClone();
        B1.Name = "�ݺ�������";
        B1.index = 5;
        StaDB.stg[0].allocBlocks.Add(B1);


        BlockClone B2 = new BlockClone();
        B2.Name = "�ൿ�ϱ�";
        B2.index = 140;
        StaDB.stg[0].allocBlocks.Add(B2);

        BlockClone B3 = new BlockClone();
        B3.Name = "�ൿ�ϱ�";
        B3.index = 150;
        StaDB.stg[0].allocBlocks.Add(B3);

        BlockClone B4 = new BlockClone();
        B4.Name = "�ݺ�����";
        B4.index = 0;
        StaDB.stg[0].allocBlocks.Add(B4);

        BlockClone B5 = new BlockClone();
        B5.Name = "��";
        B5.index = 0;
        StaDB.stg[0].allocBlocks.Add(B5);

    }
    public void SetStage2()
    {
        BlockClone B1 = new BlockClone();
        B1.Name = "�Է¹�";
        B1.index = 4120;
        StaDB.stg[1].allocBlocks.Add(B1);


        BlockClone B2 = new BlockClone();
        B2.Name = "��";
        B2.index = 0;
        StaDB.stg[1].allocBlocks.Add(B2);

    }
    public void SetStage3()
    {

        BlockClone B2 = new BlockClone();
        B2.Name = "�ൿ�ϱ�";
        B2.index = 110;
        StaDB.stg[2].allocBlocks.Add(B2);

        BlockClone B3 = new BlockClone();
        B3.Name = "�ൿ�ϱ�";
        B3.index = 120;
        StaDB.stg[2].allocBlocks.Add(B3);

        BlockClone B4 = new BlockClone();
        B4.Name = "��ٸ���";
        B4.index = 3;
        StaDB.stg[2].allocBlocks.Add(B4);

        BlockClone B5 = new BlockClone();
        B5.Name = "��";
        B5.index = 0;
        StaDB.stg[2].allocBlocks.Add(B5);
    }
    public void SetStage4()
    {
        BlockClone B1 = new BlockClone();
        B1.Name = "�ݺ�����ü";
        B1.index = 0;
        StaDB.stg[3].allocBlocks.Add(B1);


        BlockClone B2 = new BlockClone();
        B2.Name = "�ൿ�ϱ�";
        B2.index = 160;
        StaDB.stg[3].allocBlocks.Add(B2);

        BlockClone B3 = new BlockClone();
        B3.Name = "���ǹ�";
        B3.index = 30;
        StaDB.stg[3].allocBlocks.Add(B3);

        BlockClone B4 = new BlockClone();
        B4.Name = "�ൿ�ϱ�";
        B4.index = 170;
        StaDB.stg[3].allocBlocks.Add(B4);

        BlockClone B5 = new BlockClone();
        B5.Name = "���ǹ���";
        B5.index = 0;
        StaDB.stg[3].allocBlocks.Add(B5);

        BlockClone B6 = new BlockClone();
        B6.Name = "�ݺ�����";
        B6.index = 0;
        StaDB.stg[3].allocBlocks.Add(B6);

        BlockClone B7 = new BlockClone();
        B7.Name = "��";
        B7.index = 0;
        StaDB.stg[3].allocBlocks.Add(B7);

    }
    public void SetStage5()
    {
        //5
        BlockClone B1 = new BlockClone();
        B1.Name = "�ൿ�ϱ�";
        B1.index = 100;
        StaDB.stg[4].allocBlocks.Add(B1);


        BlockClone B2 = new BlockClone();
        B2.Name = "�ൿ�ϱ�";
        B2.index = 100;
        StaDB.stg[4].allocBlocks.Add(B2);

        BlockClone B3 = new BlockClone();
        B3.Name = "�ൿ�ϱ�";
        B3.index = 90;
        StaDB.stg[4].allocBlocks.Add(B3);

        BlockClone B4 = new BlockClone();
        B4.Name = "�ൿ�ϱ�";
        B4.index = 100;
        StaDB.stg[4].allocBlocks.Add(B4);

        BlockClone B5 = new BlockClone();
        B5.Name = "�ൿ�ϱ�";
        B5.index = 90;
        StaDB.stg[4].allocBlocks.Add(B5);

        BlockClone B6 = new BlockClone();
        B6.Name = "�ൿ�ϱ�";
        B6.index = 90;
        StaDB.stg[4].allocBlocks.Add(B6);

        BlockClone B7 = new BlockClone();
        B7.Name = "�ൿ�ϱ�";
        B7.index = 100;
        StaDB.stg[4].allocBlocks.Add(B7);

        BlockClone B8 = new BlockClone();
        B8.Name = "��";
        B8.index = 0;
        StaDB.stg[4].allocBlocks.Add(B8);

    }
    public void SetStage6()
    {
        BlockClone B1 = new BlockClone();
        B1.Name = "�ݺ�������";
        B1.index = 5;
        StaDB.stg[5].allocBlocks.Add(B1);


        BlockClone B2 = new BlockClone();
        B2.Name = "���ǹ�";
        B2.index = 10;
        StaDB.stg[5].allocBlocks.Add(B2);

        BlockClone B3 = new BlockClone();
        B3.Name = "�����̱�";
        B3.index = 50;
        StaDB.stg[5].allocBlocks.Add(B3);

        BlockClone B4 = new BlockClone();
        B4.Name = "���ǹ���";
        B4.index = 0;
        StaDB.stg[5].allocBlocks.Add(B4);

        BlockClone B5 = new BlockClone();
        B5.Name = "���ǹ�";
        B5.index = 20;
        StaDB.stg[5].allocBlocks.Add(B5);

        BlockClone B6 = new BlockClone();
        B6.Name = "�����̱�";
        B6.index = 60;
        StaDB.stg[5].allocBlocks.Add(B6);

        BlockClone B7 = new BlockClone();
        B7.Name = "���ǹ���";
        B7.index = 0;
        StaDB.stg[5].allocBlocks.Add(B7);

        BlockClone B8 = new BlockClone();
        B8.Name = "�ݺ�����";
        B8.index = 0;
        StaDB.stg[5].allocBlocks.Add(B8);

        BlockClone B9 = new BlockClone();
        B9.Name = "��";
        B9.index = 0;
        StaDB.stg[5].allocBlocks.Add(B9);
        //6
        
    }
    public void SetStage7()
    {
        //7
        BlockClone B1 = new BlockClone();
        B1.Name = "�����̱�";
        B1.index = 40;
        StaDB.stg[6].allocBlocks.Add(B1);

        BlockClone B2 = new BlockClone();
        B2.Name = "�����̱�";
        B2.index = 40;
        StaDB.stg[6].allocBlocks.Add(B2);

        BlockClone B3 = new BlockClone();
        B3.Name = "�����̱�";
        B3.index = 70;
        StaDB.stg[6].allocBlocks.Add(B3);

        BlockClone B4 = new BlockClone();
        B4.Name = "�����̱�";
        B4.index = 40;
        StaDB.stg[6].allocBlocks.Add(B4);

        BlockClone B5 = new BlockClone();
        B5.Name = "�����̱�";
        B5.index = 80;
        StaDB.stg[6].allocBlocks.Add(B5);

        BlockClone B6 = new BlockClone();
        B6.Name = "�����̱�";
        B6.index = 70;
        StaDB.stg[6].allocBlocks.Add(B6);

        BlockClone B7 = new BlockClone();
        B7.Name = "�����̱�";
        B7.index = 40;
        StaDB.stg[6].allocBlocks.Add(B7);

        BlockClone B8 = new BlockClone();
        B8.Name = "��";
        B8.index = 0;
        StaDB.stg[6].allocBlocks.Add(B8);
    }
    public void SetStage8()
    {
        //8
        BlockClone B1 = new BlockClone();
        B1.Name = "�ݺ�������";
        B1.index = 4;
        StaDB.stg[7].allocBlocks.Add(B1);

        BlockClone B2 = new BlockClone();
        B2.Name = "�ൿ�ϱ�";
        B2.index = 190;
        StaDB.stg[7].allocBlocks.Add(B2);

        BlockClone B3 = new BlockClone();
        B3.Name = "�ݺ�����";
        B3.index = 0;
        StaDB.stg[7].allocBlocks.Add(B3);

        BlockClone B4 = new BlockClone();
        B4.Name = "�ൿ�ϱ�";
        B4.index = 180;
        StaDB.stg[7].allocBlocks.Add(B4);

        BlockClone B5 = new BlockClone();
        B5.Name = "��";
        B5.index = 0;
        StaDB.stg[7].allocBlocks.Add(B5);
    }
    public void SetStage9()
    {
        //9
        BlockClone B1 = new BlockClone();
        B1.Name = "�����̱�";
        B1.index = 50;
        StaDB.stg[8].allocBlocks.Add(B1);

        BlockClone B2 = new BlockClone();
        B2.Name = "�����̱�";
        B2.index = 60;
        StaDB.stg[8].allocBlocks.Add(B2);

        BlockClone B3 = new BlockClone();
        B3.Name = "�����̱�";
        B3.index = 50;
        StaDB.stg[8].allocBlocks.Add(B3);

        BlockClone B4 = new BlockClone();
        B4.Name = "�����̱�";
        B4.index = 60;
        StaDB.stg[8].allocBlocks.Add(B4);

        BlockClone B5 = new BlockClone();
        B5.Name = "�����̱�";
        B5.index = 60;
        StaDB.stg[8].allocBlocks.Add(B5);

        BlockClone B6 = new BlockClone();
        B6.Name = "�����̱�";
        B6.index = 50;
        StaDB.stg[8].allocBlocks.Add(B6);

        BlockClone B7 = new BlockClone();
        B7.Name = "�����̱�";
        B7.index = 50;
        StaDB.stg[8].allocBlocks.Add(B7);

        BlockClone B8 = new BlockClone();
        B8.Name = "��";
        B8.index = 0;
        StaDB.stg[8].allocBlocks.Add(B8);
    }
    public void SetStage10()
    {
        //10
        BlockClone B2 = new BlockClone();
        B2.Name = "�ݺ�����ü";
        B2.index = 0;
        StaDB.stg[9].allocBlocks.Add(B2);

        BlockClone B3 = new BlockClone();
        B3.Name = "�ൿ�ϱ�";
        B3.index = 130;
        StaDB.stg[9].allocBlocks.Add(B3);

        BlockClone B4 = new BlockClone();
        B4.Name = "�ݺ�����";
        B4.index = 0;
        StaDB.stg[9].allocBlocks.Add(B4);

        BlockClone B5 = new BlockClone();
        B5.Name = "��";
        B5.index = 0;
        StaDB.stg[9].allocBlocks.Add(B5);
    }

}
