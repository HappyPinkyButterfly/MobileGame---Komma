using TMPro;
using UnityEngine;

public class Truth : MonoBehaviour
{
    public GameEffects gameEffects;
    public TextMeshProUGUI question;

    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        int index = Random.Range(0, gameEffects.truth.Count);
        question.text = gameEffects.truth[index];
        question.fontSize = 132f;
    }
}
