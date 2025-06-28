using TMPro;
using UnityEngine;

public class FaceOff : MonoBehaviour
{
    public GameEffects gameEffects { get; set;}
    public TextMeshProUGUI wrongEffect;

    public TextMeshProUGUI distance;

    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        wrongEffect.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        if (wrongEffect.text.Length > 30)
        {
            wrongEffect.fontSize = 78f + gameEffects.fontControlSmall;
        }
        else
        {
            wrongEffect.fontSize = 98f + gameEffects.fontControlBig;
        }

        distance.text = gameEffects.GenerateRandomEffect(gameEffects.contestTypes);



    }
}
