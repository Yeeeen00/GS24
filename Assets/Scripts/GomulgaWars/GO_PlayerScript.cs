using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GO_PlayerScript : MonoBehaviour
{
    bool Enemy2Exist = false;
    public static bool IsDrag;
    bool IsMove;
    public static int P_num = 0;
    public static int SaveNum;
    public static int GO_SaveP_num = 0;
    public Text P_text;
    int Numsum=0;
    Collider2D Collider;
    Collider2D Collider2;

    private void Awake(){
        GO_GameManager.Stage += 1;
        if(GO_GameManager.Stage==1)
            P_num = Random.Range(5, 10);
        IsDrag = true;
        IsMove = true;
    }
    private void Start(){
        SaveNum = P_num;
    }
    private void Update(){
        if (P_num > GO_SaveP_num){
            GO_SaveP_num=P_num;
        }
        P_text.text = P_num.ToString();
        if (IsMove == true){
            IsDrag = true;
        }
        if (IsMove == false){
            IsDrag = false;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Enemy"){
            Collider = collision;
            IsMove = false;
            GetComponent<GO_AttackScript>().Attack();
            Invoke("EnemyFight", 2);
        }
        if (collision.tag == "Enemy2")
        {
            Collider2 = collision;
            Enemy2Exist = true;
        }
    }
    public void EnemyFight(){
        if (Collider.GetComponent<GO_EnemyScript>().M_num < P_num){
            if (Enemy2Exist == true) {
                Numsum += Collider.GetComponent<GO_EnemyScript>().M_num;
                Invoke("Enemy2Fight", 2);
            }
            else {
                P_num += Collider.GetComponent<GO_EnemyScript>().M_num;
                GetComponent<GO_AttackScript>().OffAttack();
                IsMove = true;
            }
            Destroy(Collider.gameObject);
        }
        if (Collider.GetComponent<GO_EnemyScript>().M_num > P_num){
            Destroy(gameObject);
        }
        if (Collider.GetComponent<GO_EnemyScript>().M_num == P_num){
            Destroy(Collider.gameObject);
            Destroy(gameObject);
        }
    }
    public void Enemy2Fight(){
        if (Collider2.GetComponent<GO_Enemy2Script>().M_num < P_num){
            P_num += Collider2.GetComponent<GO_Enemy2Script>().M_num + Numsum;
            Destroy(Collider2.gameObject);
            GetComponent<GO_AttackScript>().OffAttack();
            Enemy2Exist = false;
            Numsum = 0;
            IsMove = true;
        }
        if (Collider2.GetComponent<GO_Enemy2Script>().M_num > P_num){
            Destroy(gameObject);
        }
        if (Collider2.GetComponent<GO_Enemy2Script>().M_num == P_num){
            Destroy(Collider2.gameObject);
            Destroy(gameObject);
        }
    }
}
