using System;
using Bolt_2D_DinoRun_VE1;
using UnityEngine;
[RequireComponent(typeof(dinoAnimator))]

public class dinoController : MonoBehaviour
{
    // Start is called before the first frame update
    private dinoAnimator anim;
    private int currentScore;
    [SerializeField] private GameObject ScoreTextObject;
    [SerializeField] private GameObject GameOverSystemObject;
    private ShowCurrentScore _showCurrentScore;
    void Start()
    {
        GameOverSystemObject.SetActive(false);
        _showCurrentScore = ScoreTextObject.GetComponent<ShowCurrentScore>();
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
            GameOverSystem();
        }

        if (col.gameObject.GetComponent<AddScore>())
        {
            currentScore += 1;
            _showCurrentScore.UpdateScoreText(currentScore);
            Destroy(col.gameObject);
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

    void GameOverSystem()
    {
        GameOverSystemObject.SetActive(true);
    }
}
