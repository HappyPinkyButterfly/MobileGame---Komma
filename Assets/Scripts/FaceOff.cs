using TMPro;
using UnityEngine;

public class FaceOff : MonoBehaviour
{
    public GameEffects gameEffects;
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
    
    }
}
