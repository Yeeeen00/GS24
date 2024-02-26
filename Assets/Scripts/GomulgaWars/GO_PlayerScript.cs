using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GO_PlayerScript : MonoBehaviour
{
    public static bool IsDrag = true;
    bool IsMove = true;
    public static int P_num = 0;
    public Text P_text;
    int Numsum=0;
    Collider2D Collider;

    private void Awake(){
        P_num += Random.Range(4, 10);
    }
    private void Update(){
        P_text.text = P_num.ToString();
        if (IsMove!=false){
            IsDrag = true;
        }
        if (IsMove != true){
            IsDrag = false;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Enemy"){
            Collider = collision;
            IsMove = false;
            Invoke("EnemyFight", 2);
        }
        if(collision.tag =="Enemy2"){
            Collider=collision;
            IsMove = false;
            Invoke("Enemy2Fight", 2);
        }
    }
    public void EnemyFight() {
        if (Collider.GetComponent<GO_EnemyScript>().M_num < P_num){
            if (Collider.name == GO_Enemy2Script.EnemyName){
                Numsum += Collider.GetComponent<GO_EnemyScript>().M_num;
            }
            else if(Collider.name != GO_Enemy2Script.EnemyName){
                P_num += Collider.GetComponent<GO_EnemyScript>().M_num;
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
        if (Collider.GetComponent<GO_Enemy2Script>().M_num < P_num){
            P_num += Collider.GetComponent<GO_Enemy2Script>().M_num + Numsum;
            Destroy(Collider.gameObject);
            Numsum = 0;
            IsMove =true;
        }
        if (Collider.GetComponent<GO_Enemy2Script>().M_num > P_num){
            Destroy(gameObject);
        }
        if (Collider.GetComponent<GO_Enemy2Script>().M_num == P_num){
            Destroy(Collider.gameObject);
            Destroy(gameObject);
        }
    }
}
