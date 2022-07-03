using System.Collections;
using System.Collections.Generic;
using Bolt_2D_DinoRun_VE1;
using UnityEngine;

public class PauseSystem : MonoBehaviour
{
    // Start is called before the first frame update
    private float currentSpeed;
    void Start()
    {
        GlobalEventManager.PauseOnEvent += PauseOn;
        GlobalEventManager.PauseOffEvent += PauseOff;
        GlobalEventManager.UnsubscribeFromEvent += UnsubscribeFromEvent;
        currentSpeed = GetComponent<Animator>().speed;
    }

    // Update is called once per frame
    void PauseOn()
    {
        gameObject.GetComponent<Animator>().speed = 0;
    }    
    
    void PauseOff()
    {
        gameObject.GetComponent<Animator>().speed = currentSpeed;
    }

    public bool UnsubscribeFromEventBeforeDestroy()
    {
        GlobalEventManager.PauseOnEvent -= PauseOn;
        GlobalEventManager.PauseOffEvent -= PauseOff;
        return true;
    }
    void UnsubscribeFromEvent()
    {
        GlobalEventManager.PauseOnEvent -= PauseOn;
        GlobalEventManager.PauseOffEvent -= PauseOff;
        GlobalEventManager.UnsubscribeFromEvent -= UnsubscribeFromEvent;
    }

}
