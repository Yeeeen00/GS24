using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageDatabase : MonoBehaviour
{
    public static StageDatabase Instance;
    private void Awake()
    {
        Instance = this;
    }
    public List<stage> stg = new List<stage>();
}
