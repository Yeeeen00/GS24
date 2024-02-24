using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotScript : MonoBehaviour, IDropHandler
{
    GameObject Player()
    {
        if (transform.childCount > 0) {
            return transform.GetChild(0).gameObject;
        }
        else { return null; }
    }
    public void OnDrop(PointerEventData eventData)
    {
        if (Player() == null) { 
            DragHandler.beingDraggedPlayer.transform.SetParent(transform);
            DragHandler.beingDraggedPlayer.transform.position = transform.position;
            DragHandler.Boxbool = true;
        }
    }
}
