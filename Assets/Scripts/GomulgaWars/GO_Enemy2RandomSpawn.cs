using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GO_Enemy2RandomSpawn : MonoBehaviour
{
    public GameObject prefabs;
    int count;
    private int RandTransform;
    [SerializeField]List<GameObject> Enemy = new List<GameObject>();
    Vector3[]EnemyPosition = new Vector3[10];

    // Start is called before the first frame update
    void Start(){
        count = Random.Range(3, 7);
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
        //int r;
        int[] rand= Rndomnumbers(10, count);
        for(int i = 0; i < rand.Length; ++i)
        {
            Instantiate(prefabs, EnemyPosition[rand[i]], Quaternion.identity, GameObject.Find("MainPanel").transform);
        }
    }
    int[] Rndomnumbers(int maxCount,int n)
    {
        int[] defaults = new int[maxCount];
        int[] results = new int[n];
        for(int i = 0;i < maxCount;i++) {
            defaults[i] = i;
        }
        for(int i = 0;i<n;i++){
            int index=Random.Range(0, maxCount);
            results[i] = defaults[index];
            defaults[index] = defaults[maxCount-1];
            maxCount--;
        }
        return results;
    }
}
