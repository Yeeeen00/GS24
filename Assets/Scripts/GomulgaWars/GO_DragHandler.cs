using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 

public class GO_DragHandler : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public static GameObject beingDraggedPlayer;
    public static bool Boxbool;
    Vector3 startPosition;
    public AudioClip DragSound;
    AudioSource GameSound;
    [HideInInspector] public Transform startParent;
    [SerializeField] Transform onDragParent;
    void Start(){
        GameSound = GetComponent<AudioSource>();
    }

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
        GameSound.PlayOneShot(DragSound);
    }
    public void OnDrag(PointerEventData eventData)
    {
        if (GO_PlayerScript.IsDrag != false){ 
            Boxbool= false;
            transform.position = Input.mousePosition;
        }
    }
}
