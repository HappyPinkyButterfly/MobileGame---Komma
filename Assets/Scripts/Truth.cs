using TMPro;
using UnityEngine;

public class Truth : MonoBehaviour
{
    public GameEffects gameEffects;
    public TextMeshProUGUI question;

    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        question.text = gameEffects.GenerateRandomEffect(gameEffects.truth);
        question.fontSize = 100f;
    }
}
