using TMPro;
using UnityEngine;

public class GuessUnderwear : MonoBehaviour
{
    public GameEffects gameEffects { get; set;}
    public TextMeshProUGUI correctEffect;
    public TextMeshProUGUI wrongEffect;

    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        wrongEffect.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        if (wrongEffect.text.Length > 30)
        {
            wrongEffect.fontSize = 58f;
            
        }
        else
        {
            wrongEffect.fontSize = 95f;
        }

        correctEffect.text = gameEffects.GenerateRandomEffect(gameEffects.goodEffects);
        if (correctEffect.text.Length > 30)
        {
            correctEffect.fontSize = 58f;
        }
        else
        {
            correctEffect.fontSize = 95f;
        }
    
    }

}
