using System;
using System.Collections;
using System.Collections.Generic;
using Bolt_2D_DinoRun_VE1;
using UnityEngine;
[RequireComponent(typeof(Animator), typeof(Rigidbody2D), typeof(BoxCollider2D))]
public class dinoAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator DinoAnimator;
    [SerializeField] private Sprite DeathSprite;
    void Start()
    {
       DinoAnimator = GetComponent<Animator>();
    }
    public void Jump(bool IsJumping)
    {
        DinoAnimator.SetBool("IsJumpingAnimator", IsJumping);
    }
    public void Death()
    {
        DinoAnimator.speed = 0;
        DinoAnimator.enabled = false;
        gameObject.GetComponent<SpriteRenderer>().sprite = DeathSprite;
        
        //alt version with animator
        /*
         * DinoAnimator.speed = 0;
         * DinoAnimator.SetBool("IsKilled", true);
         * 
         */
    }
}
