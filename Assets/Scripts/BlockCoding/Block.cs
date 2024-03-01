using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type
{
    block,
    move,
    action
}

[CreateAssetMenu]
public class Block : ScriptableObject
{
    public string Name;
    public int index;
    public Type type;
    public Sprite Image;
}
