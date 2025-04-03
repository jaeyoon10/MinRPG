using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{

   public Animator animator;
    public Animation cube;
    
    void Start()
    {
        animator.SetBool("JumpBool", true);
        animator.SetBool("JumpBool", false);
    }

    public void Attack()
    {
        animator.SetTrigger("AttackTrigger");
    }

    public void Damage() 
    {
        animator.SetTrigger("DamageTrigger");
    }

    public void CubeAnimation()
    {
        cube.Play("CubeRotate");
    }
}
