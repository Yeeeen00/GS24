using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GO_PlayerSkin : MonoBehaviour
{
    public Sprite[] psprite;
    Image pimage;
    public static int Level;
    private void Start()
    {
        pimage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GO_PlayerScript.P_num >= 1 && GO_PlayerScript.P_num < 30)
        {
            pimage.sprite = psprite[0];
            Level = 1;
        }
        if (GO_PlayerScript.P_num >= 30 && GO_PlayerScript.P_num < 60)
        {
            pimage.sprite = psprite[1];
            Level = 2;
        }
        if (GO_PlayerScript.P_num >= 60 && GO_PlayerScript.P_num < 100)
        {
            pimage.sprite = psprite[2];
            Level = 3;
        }
        if (GO_PlayerScript.P_num >= 100 && GO_PlayerScript.P_num < 200)
        {
            pimage.sprite = psprite[3];
            Level = 4;
        }
        if (GO_PlayerScript.P_num >= 200 && GO_PlayerScript.P_num < 450)
        {
            pimage.sprite = psprite[4];
            Level = 5;
        }
        if (GO_PlayerScript.P_num >= 450)
        {
            pimage.sprite = psprite[5];
            Level = 6;
        }
    }
}
