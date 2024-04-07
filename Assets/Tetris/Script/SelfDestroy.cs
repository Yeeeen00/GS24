using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    public float LifeTime = 3;
    void Start()
    {
        Invoke("destroyMe", LifeTime);
    }

    void destroyMe()
    {
        Destroy(this.gameObject);
    }
}
