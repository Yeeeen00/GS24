using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GO_SlotScript : MonoBehaviour, IDropHandler
{
    public AudioClip DropSound;
    AudioSource GameSound;
    void Start(){
        GameSound = GetComponent<AudioSource>();
    }
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
            GO_DragHandler.beingDraggedPlayer.transform.SetParent(transform);
            GO_DragHandler.beingDraggedPlayer.transform.position = transform.position;
            GO_DragHandler.Boxbool = true;
            GameSound.PlayOneShot(DropSound);
        }
    }
}
