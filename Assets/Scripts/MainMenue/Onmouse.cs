using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Onmouse : MonoBehaviour
{
    void OnMouseExit()
    {
        GetComponent<Outline>().enabled = false;
    }
    void OnMouseEnter()
    {
        GetComponent<Outline>().enabled = true;
    }
}
