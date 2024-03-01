using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GO_EnemyScript : MonoBehaviour
{
    GameObject pobj;
    bool enemyCheck = true; 
    public int M_num = 0;
    public Text M_text;
    public static bool Enemy2Col;
    public Sprite[] sprites;
    BoxCollider2D box;
    public void Awake()
    {
        int randnumber = Random.Range(0, 11);
        GetComponent<Image>().sprite = sprites[randnumber];
        GetComponent<GO_ChangeImage>().EnemyAni = randnumber;
    }

    private void Start(){
        M_num += GO_PlayerScript.P_num + Random.Range(-4, 5);
        box = GetComponent<BoxCollider2D>();
    }

    private void Update(){
        M_text.text = M_num.ToString();
        if (enemyCheck!=false){
            if (gameObject.transform.localPosition.x >= 530) {
                M_num += Random.Range(6, 14);
                if (GO_GameManager.Stage >= 2)
                    M_num *= Random.Range(1, 4);
            }
            if(gameObject.transform.localPosition.y >= 280) {
                M_num += Random.Range(4, 9);
                if (GO_GameManager.Stage >= 2)
                    M_num *= Random.Range(1, 3);
            }
            enemyCheck = false;
        }
        if (GO_DragHandler.Boxbool == true) box.enabled = true;
        if (GO_DragHandler.Boxbool == false) box.enabled = false;
    }
}
