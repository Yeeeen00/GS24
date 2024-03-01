using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu]
public class stage : ScriptableObject
{
    public int StageIndex;
    public Sprite image;
    public List<BlockClone> allocBlocks = new List<BlockClone>();
}

