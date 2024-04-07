using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Command
{
    Left,
    Right,
    MoveDown,
    Down,
    Rotate,
    None
}

public class TouchButtons : MonoBehaviour
{

    public Command MyCommand;
    //[SerializeField] TouchHandler BtnLeft, BtnRight, BtnMoveDown, BtnDown, BtnRotate;

    void Start()
    {
        //BtnLeft.onTouchDown.AddListener(() => SetCommand(Command.Left));
        //BtnRight.onTouchDown.AddListener(() => SetCommand(Command.Right));
        //BtnRotate.onTouchDown.AddListener(() => SetCommand(Command.Rotate));
        //BtnMoveDown.onTouchDown.AddListener(() => SetCommand(Command.MoveDown));
        //BtnDown.onTouchDown.AddListener(() => SetCommand(Command.Down));

        //BtnLeft.onTouchUp.AddListener(ResetCommand);
        //BtnRight.onTouchUp.AddListener(ResetCommand);
        //BtnRotate.onTouchUp.AddListener(ResetCommand);
        //BtnMoveDown.onTouchUp.AddListener(ResetCommand);
        //BtnDown.onTouchUp.AddListener(ResetCommand);
    }

    void SetCommand(Command type)
    {
        MyCommand = type;
        Debug.Log("type : " + type);
    }
    void ResetCommand()
    {
        Debug.Log("type : " + MyCommand);
        MyCommand = Command.None;
    }
}