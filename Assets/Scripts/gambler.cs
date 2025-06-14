using TMPro;
using UnityEngine;

public class gambler : MonoBehaviour
{
    public GameEffects gameEffects { get; set;}
    public TextMeshProUGUI coorectEffect;
    public TextMeshProUGUI wrongEffect;

    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        coorectEffect.text = gameEffects.GenerateRandomEffect(gameEffects.goodEffects);
        wrongEffect.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        if (coorectEffect.text.Length > 30)
        {
            coorectEffect.fontSize = 58f;

        }
        else
        {
            coorectEffect.fontSize = 88f;
        }

        if (wrongEffect.text.Length > 30)
        {
            wrongEffect.fontSize = 58f;

        }
        else
        {
            wrongEffect.fontSize = 88f;
        }

    }
}
