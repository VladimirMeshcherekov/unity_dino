using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySystem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<DestroyThisObj>() && col.TryGetComponent(out PauseSystem pauseSystem))
        {
            if (pauseSystem.UnsubscribeFromEventBeforeDestroy() == true)
            {
                 Destroy(col.gameObject);
            }
        }
    }

  
}
