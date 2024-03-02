using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Vector2 inputvecter;

    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        inputvecter.x = Input.GetAxis("Horizontal");
        inputvecter.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rigid.AddForce(inputvecter);

        rigid.velocity = inputvecter;

        rigid.MovePosition(rigid.position + inputvecter);
    }

}
