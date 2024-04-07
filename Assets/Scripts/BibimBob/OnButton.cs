using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnButton : MonoBehaviour
{
    public Text text;
    Color color;
    Color savecolor;
    string color_name;
    private void Start(){
        savecolor=text.color;
    }
    void OnMouseExit()
    {
        text.color=savecolor;
    }
    void OnMouseEnter(){
        color_name = "#FFFFFF";
        if(ColorUtility.TryParseHtmlString(color_name,out color))
            text.color = color;
    }
}
