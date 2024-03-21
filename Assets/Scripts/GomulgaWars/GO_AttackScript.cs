using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_AttackScript : MonoBehaviour
{
    public AudioClip attacksoundClip;
    AudioSource attackSoundSource;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        attackSoundSource = GetComponent<AudioSource>();
        animator=GetComponent<Animator>();
        animator.enabled = false;
    }
    public void Attack()
    {
        animator.enabled = true;
        if (GO_PlayerSkin.Level == GO_PlayerSkin.IsLevel)
        {
            animator.SetTrigger(GO_PlayerSkin.Ani);
            attackSoundSource.PlayOneShot(attacksoundClip);
            Invoke("deley", 1);
        }
    }
    public void OffAttack()
    {
        animator.enabled = false;
    }
    void deley()
    {
        attackSoundSource.PlayOneShot(attacksoundClip);
    }
}
