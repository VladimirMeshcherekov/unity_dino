using System;
using Bolt_2D_DinoRun_VE1;
using UnityEngine;
[RequireComponent(typeof(dinoAnimator))]

public class dinoController : MonoBehaviour
{
    // Start is called before the first frame update
    private dinoAnimator anim;
    void Start()
    {
       anim = gameObject.GetComponent<dinoAnimator>();
    }

    public void IsTouching(bool IsTouching)
    {
        anim.Jump(IsTouching);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<killPlayer>())
        {
            anim.Death();
            GlobalEventManager.PauseOnEvent();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GlobalEventManager.PauseOnEvent();
        }       
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GlobalEventManager.PauseOffEvent();
        }
    }
}
