using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_AttackScript : MonoBehaviour
{
    public Transform Target;
    int speed = 330;
    bool f=true;

    void Update()
    {
        Invoke("haha", 0.4f);//0.4�ʵ�
        Invoke("gogo", 0.8f);//0.6�ʵ�
        transform.RotateAround(Target.position, Vector3.forward, speed * Time.deltaTime);
    }

    void dh()
    {
        if (f == true)
        {
            
            f = false;
        }
        // �־��� ���� �߽����� ȸ��
        
    }
    void haha()
    {
        speed = -330;//�Ʒ���
        
    }
    void gogo()
    {
        speed = 330;//����
    }
    void dddd()
    {
        speed = -300;
        
    }
}
