using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 

public class GO_DragHandler : MonoBehaviour, IDragHandler,IBeginDragHandler,IEndDragHandler
{
    public static bool Boxbool;
    public static GameObject beingDraggedPlayer;
    Vector3 startPosition;
    [HideInInspector] public Transform startParent;
    [SerializeField] Transform onDragParent;

    public void OnEndDrag(PointerEventData eventData)
    {
        beingDraggedPlayer = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if(transform.parent == onDragParent)
        {
            transform.position = startPosition;
            transform.SetParent(startParent);
        }
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        beingDraggedPlayer = gameObject;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        startPosition = transform.position;
        startParent = transform.parent;
        transform.SetParent(onDragParent);
    }
    public void OnDrag(PointerEventData eventData)
    {
        Boxbool = false;
        transform.position = Input.mousePosition;
    }
}
