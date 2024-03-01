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
        Invoke("haha", 0.4f);//0.4초뒤
        Invoke("gogo", 0.8f);//0.6초뒤
        transform.RotateAround(Target.position, Vector3.forward, speed * Time.deltaTime);
    }

    void dh()
    {
        if (f == true)
        {
            
            f = false;
        }
        // 주어진 축을 중심으로 회전
        
    }
    void haha()
    {
        speed = -330;//아래로
        
    }
    void gogo()
    {
        speed = 330;//위로
    }
    void dddd()
    {
        speed = -300;
        
    }
}
