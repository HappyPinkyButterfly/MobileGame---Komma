using TMPro;
using UnityEngine;

public class CallOfTheWILD : MonoBehaviour
{
    public TextMeshProUGUI typeOfEffect;

    public GameEffects gameEffects { get; set;}

    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        typeOfEffect.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        if (typeOfEffect.text.Length > 30)
        {
            typeOfEffect.fontSize = 78f + gameEffects.fontControlSmall;
        }
        else
        {
            typeOfEffect.fontSize = 98f + gameEffects.fontControlBig;
        }
    
    }
}
