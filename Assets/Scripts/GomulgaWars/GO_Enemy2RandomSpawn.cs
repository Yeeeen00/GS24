using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GO_Enemy2RandomSpawn : MonoBehaviour
{
    public GameObject prefabs;
    public int count;
    private int RandTransform;
    [SerializeField]List<GameObject> Enemy = new List<GameObject>();
    Vector3[]EnemyPosition = new Vector3[10];

    // Start is called before the first frame update
    void Start(){
        count = Random.Range(4, 8);
        int num = 0;
        foreach (GameObject obj in Enemy){
            EnemyPosition[num] = obj.transform.position;
            EnemyPosition[num].x += 160;
            num++;
        }
        Spawn(count);
    }
    void Spawn(int count)
    {
        int randpos;
        for (int i = 0; i < count; i++) {
            randpos = Random.Range(0, 10);
            Instantiate(prefabs, EnemyPosition[randpos],Quaternion.identity,GameObject.Find("MainPanel").transform);
        }
    }
}
