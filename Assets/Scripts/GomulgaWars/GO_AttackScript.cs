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
    public void Attack()
    {
        animator.enabled = true;
        if (GO_PlayerSkin.Level == GO_PlayerSkin.IsLevel)
        {
            animator.SetTrigger(GO_PlayerSkin.Ani);
        }
    }
    public void OffAttack()
    {
        animator.enabled = false;
    }
}
