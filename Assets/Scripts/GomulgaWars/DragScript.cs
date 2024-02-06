using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragScript : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    float startPosx;
    float startPosY;
    bool isBeingHeld = false;
    public bool isIn;
    Vector3 HitBoxPos;

    private void Update()
    {
        if (isBeingHeld)
        {
            Vector2 mousePos;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            this.gameObject.transform.position = new Vector2(mousePos.x - startPosx, mousePos.y - startPosY);
        }
    }


    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            spriteRenderer.color = new Color(1f, 1f, 1f, .5f);
            Vector3 mousePos;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            startPosx = mousePos.x - this.transform.position.x;
            startPosY = mousePos.y - this.transform.position.y;

            isBeingHeld = true;
        }
    }
    private void OnMouseUp()
    {
        spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
        isBeingHeld = false;
        if (isIn)
            this.gameObject.transform.position = HitBoxPos;
        else if (isIn == false)
            this.gameObject.transform.position = HitBoxPos;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("HitBox"))
        {
            isIn = true;
            HitBoxPos = other.transform.position;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("HitBox"))
        {
            isIn = false;
        }
    }
}