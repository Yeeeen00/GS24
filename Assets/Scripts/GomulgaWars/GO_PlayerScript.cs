using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GO_PlayerScript : MonoBehaviour
{
    public static int P_num = 0;
    public Text P_text;
    int Numsum=0;

    private void Awake(){
        P_num += Random.Range(3, 11);
    }
    private void Update(){
        P_text.text = P_num.ToString();
    }
    public void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Enemy"){
            if (collision.GetComponent<GO_EnemyScript>().M_num < P_num){
                if(collision.name == GO_Enemy2Script.EnemyName){
                    Numsum += collision.GetComponent<GO_EnemyScript>().M_num;
                }
                else
                    P_num+= collision.GetComponent<GO_EnemyScript>().M_num;
                Destroy(collision.gameObject);
            }
            if (collision.GetComponent<GO_EnemyScript>().M_num > P_num){
                Destroy(gameObject);
            }
            if (collision.GetComponent<GO_EnemyScript>().M_num == P_num){
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
        if(collision.tag =="Enemy2"){
            if (collision.GetComponent<GO_Enemy2Script>().M_num < P_num){
                P_num += collision.GetComponent<GO_Enemy2Script>().M_num + Numsum;
                Destroy(collision.gameObject);
                Numsum = 0;
            }
            if (collision.GetComponent<GO_Enemy2Script>().M_num > P_num){
                Destroy(gameObject);
            }
            if (collision.GetComponent<GO_Enemy2Script>().M_num == P_num){
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
    }
}
