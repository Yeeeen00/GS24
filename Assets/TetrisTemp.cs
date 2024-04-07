using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TetrisTemp : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Move", 0.5f);
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.rotation *= Quaternion.Euler(0, 0, 90f);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(
                        transform.position.x - 0.25f, transform.position.y, 0);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = new Vector3(
                        transform.position.x + 0.25f, transform.position.y, 0);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = new Vector3(
                transform.position.x, transform.position.y - 0.25f, 0);
        }
    }
    
    void Move()
    {
        transform.position = new Vector3(
            transform.position.x, transform.position.y - 0.25f, 0);
        if (!(transform.position.y <= -3.36))
            Invoke("Move", 0.5f);
    }
}
