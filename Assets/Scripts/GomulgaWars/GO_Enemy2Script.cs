using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GO_Enemy2Script : MonoBehaviour
{
    bool Enemy = false;
    bool enemyCheck = true;
    public Sprite[] sprites;
    public int M_num = 0;
    public Text M_text;
    GameObject pobj;
    Collider2D col;
    Vector3 Enemy2Move;
    BoxCollider2D box;
    

    private void Start(){
        M_num += GO_PlayerScript.P_num + Random.Range(-3, 7);
        box = GetComponent<BoxCollider2D>();
        int randnumber = Random.Range(0, 11);
        GetComponent<Image>().sprite = sprites[randnumber];
    }
    private void Update(){
        M_text.text = M_num.ToString();
        if (enemyCheck != false){
            if (gameObject.transform.localPosition.x >= 530){
                M_num += Random.Range(7, 15);
            }
            if (gameObject.transform.localPosition.y >= 280){
                M_num += Random.Range(5, 10);
            }
            enemyCheck = false;
        }
        if (Enemy == true)
            if (col == false)
                transform.localPosition = Vector3.MoveTowards(transform.localPosition, Enemy2Move, 0.7f);
        if (GO_DragHandler.Boxbool == true) box.enabled = true;
        if (GO_DragHandler.Boxbool == false) box.enabled = false;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Enemy2Move = collision.transform.localPosition;
            col = collision;
            Enemy=true;
        }
    }
}
