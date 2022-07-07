using System.Collections;
using System.Collections.Generic;
using Bolt_2D_DinoRun_VE1;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void RestartScene()
    {
     GlobalEventManager.UnsubscribeFromEvent();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
    }

}
