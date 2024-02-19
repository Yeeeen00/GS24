using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    GameObject pobj;
    public int M_num = 0;
    public Text M_text;
    private void Start()
    {
        pobj = GameObject.Find("Player");
        M_num += pobj.GetComponent<PlayerScript>().P_num + Random.Range(-5, 8);
        M_text.text = M_num.ToString();
    }
    private void Update()
    {
        if (DragHandler.Boxbool==true)
        {
            BoxCollider2D box=GetComponent<BoxCollider2D>();
            box.enabled = true;
        }
        if (DragHandler.Boxbool == false)
        {
            BoxCollider2D box = GetComponent<BoxCollider2D>();
            box.enabled = false;
        }
    }
}
