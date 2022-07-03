using System.Collections;
using System.Collections.Generic;
using Bolt_2D_DinoRun_VE1;
using UnityEngine;

public class SummonSystem : MonoBehaviour
{
    [SerializeField] private GameObject[] Cactuses;
    [SerializeField] private GameObject[] Decor;
    private float speed = 1; 
    [SerializeField] private float timeBehaindCactusSpawn = 1f;
    [SerializeField] private float MinTimeBehaindDecorSpawn = 0.5f;
    [SerializeField]private float MaxTimeBehaindDecorSpawn = 3f;
    void Start()
    {
        StartCoroutine(SpawnCactus());
        StartCoroutine(SpawnDecor());
      
        GlobalEventManager.PauseOnEvent += PauseOn;
        GlobalEventManager.PauseOffEvent += PauseOff;
        GlobalEventManager.UnsubscribeFromEvent += UnsubscribeFromEvent;




    }

    // Update is called once per frame


    IEnumerator SpawnCactus()
    {
        
        yield return new WaitForSecondsRealtime(timeBehaindCactusSpawn + Random.Range(0, 1f));
        StartCoroutine(SpawnCactus());
        Instantiate(Cactuses[Random.Range(0, Cactuses.Length)], transform.position, Quaternion.identity);
    }

    IEnumerator SpawnDecor()
    {
        Instantiate(Decor[Random.Range(0, Decor.Length)], transform.position, Quaternion.identity);
        yield return new WaitForSecondsRealtime(Random.Range(MinTimeBehaindDecorSpawn, MaxTimeBehaindDecorSpawn));
        StartCoroutine(SpawnDecor());
    }

    void PauseOn()
    {
        StopAllCoroutines();
    }    
    void PauseOff()
    {
        StartCoroutine(SpawnCactus());
    }

    void UnsubscribeFromEvent()
    {
        GlobalEventManager.PauseOnEvent -= PauseOn;
        GlobalEventManager.PauseOffEvent -= PauseOff;
        GlobalEventManager.UnsubscribeFromEvent -= UnsubscribeFromEvent;
    }
}
