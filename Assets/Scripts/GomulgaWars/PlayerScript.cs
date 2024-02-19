using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public int P_num = 0;
    public Text P_text;
    
    private void Awake()
    {
        P_num += Random.Range(-5, 8);
    }
    private void Update()
    {
        P_text.text = P_num.ToString();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            if (collision.GetComponent<EnemyScript>().M_num < P_num)
            {
                P_num += collision.GetComponent<EnemyScript>().M_num;
                Destroy(collision.gameObject);
            }
            if(collision.GetComponent<EnemyScript>().M_num > P_num)
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
    }
}
