using TMPro;
using UnityEngine;

public class GuessUnderwear : MonoBehaviour
{
    public GameEffects gameEffects;
    public TextMeshProUGUI correctEffect;
    public TextMeshProUGUI wrongEffect;

    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        int index = Random.Range(0, gameEffects.badEffects.Count);
        wrongEffect.text = gameEffects.badEffects[index];
        if (gameEffects.badEffects[index].Length > 30)
        {
            wrongEffect.fontSize = 80f;
            
        }
        else
        {
            wrongEffect.fontSize = 100f;
        }

        int index2 = Random.Range(0, gameEffects.goodEffects.Count);
        correctEffect.text = gameEffects.goodEffects[index2];
        if (gameEffects.goodEffects[index2].Length > 30)
        {
            correctEffect.fontSize = 80f;
        }
        else
        {
            correctEffect.fontSize = 100f;
        }
    
    }

}
