using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTest : MonoBehaviour
{
    public delegate void SomeEvent();

    public event SomeEvent gameStart;
    void Start()
    {
        gameStart?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
