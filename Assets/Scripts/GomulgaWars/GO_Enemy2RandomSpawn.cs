using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_Enemy2RandomSpawn : MonoBehaviour
{
    //public GameObject prefabs;
    public int count;
    private int RandTransform;
    private float[,] Enemy2transform = new float[2,4];

    // Start is called before the first frame update
    private void Awake()
    {
        //count = Random.Range(1, 4);
        //for(int i = 0; i < 2; i++)
        //{
        //    Enemy2transform[i, 0] =transform.localPosition.x
        //    for (int j = 0; j < 4; j++)
        //    {
                
        //    }
        //}
        
    }
    void Start()
    {
        //for (int i = 0; i < count; ++i)
        //{
        //    Spawn();
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        //Instantiate(prefabs);
        
    }
}
