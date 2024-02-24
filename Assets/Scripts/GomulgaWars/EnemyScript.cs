using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    GameObject pobj;
    bool enemyCheck = true; 
    public int M_num = 0;
    public Text M_text;

    private void Start(){
        M_num += PlayerScript.P_num + Random.Range(-6, 7);
    }
    private void Update(){
        M_text.text = M_num.ToString();
        if (enemyCheck!=false){
            if (gameObject.transform.localPosition.x >= 650) {
                M_num += Random.Range(7, 15);
            }
            if(gameObject.transform.localPosition.y >= 300) {
                M_num += Random.Range(5, 10);
            }
            enemyCheck = false;
        }
        if (DragHandler.Boxbool == true){
            GetComponent<BoxCollider2D>().enabled = true;
        }
        if (DragHandler.Boxbool == false){
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
