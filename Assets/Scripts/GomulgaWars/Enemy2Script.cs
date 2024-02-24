using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy2Script : MonoBehaviour
{
    GameObject pobj;
    bool enemyCheck = true;
    public int M_num = 0;
    public Text M_text;
    public static string EnemyName;
    bool Enemy = false;
    Collider2D col;
    Vector3 Enemy2Move;

    private void Start(){
        M_num += PlayerScript.P_num + Random.Range(-6, 7);
    }
    private void Update(){
        M_text.text = M_num.ToString();
        if (enemyCheck != false){
            if (gameObject.transform.localPosition.x >= 650){
                M_num += Random.Range(7, 15);
            }
            if (gameObject.transform.localPosition.y >= 300){
                M_num += Random.Range(5, 10);
            }
            enemyCheck = false;
        }
        if(Enemy == true) {
            if (col==false){
                transform.localPosition = Vector3.MoveTowards(gameObject.transform.localPosition, Enemy2Move, 1f);
            }
        }
        //놓았을때
        if (DragHandler.Boxbool == true){
            GetComponent<BoxCollider2D>().enabled = true;
        }
        //드래그할때
        if (DragHandler.Boxbool == false){
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision){
        col = collision;
        if (col.tag == "Enemy"){
            EnemyName = col.name;
            Enemy2Move = col.transform.localPosition;
            Enemy = true;
        }
    }
}
