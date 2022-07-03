using UnityEngine;
using UnityEngine.UI;

public class ShowCurrentScore : MonoBehaviour
{
    private Text _text;
    [SerializeField] private string TextBeforeScore;
    private void Start()
    {
        _text = gameObject.GetComponent<Text>();
    }

    public void UpdateScoreText(int Score)
    {
        _text.text = TextBeforeScore + Score;
    }
}
