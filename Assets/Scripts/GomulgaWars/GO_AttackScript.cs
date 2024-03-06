using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_AttackScript : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
        animator.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Attack()
    {
        animator.enabled = true;
        if (GO_PlayerSkin.Level==1)
        {
            animator.SetTrigger("01");
        }
    }
}
