using TMPro;
using UnityEngine;

public class FaceOff : MonoBehaviour
{
    public GameEffects gameEffects;
    public TextMeshProUGUI wrongEffect;
    public TextMeshProUGUI whoYouBattle;

    public TextMeshProUGUI distance;

    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        wrongEffect.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        if (wrongEffect.text.Length > 30)
        {
            wrongEffect.fontSize = 78f;
        }
        else
        {
            wrongEffect.fontSize = 98f;
        }


        whoYouBattle.text = gameEffects.GenerateRandomEffect(gameEffects.contestTypes);

   
        distance.text = gameEffects.GenerateRandomEffect(gameEffects.faceOffWho);



    }
}
