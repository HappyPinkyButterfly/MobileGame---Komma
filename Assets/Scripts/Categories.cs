using System.Linq;
using TMPro;
using UnityEngine;

public class Categories : MonoBehaviour
{
    public TextMeshProUGUI typeOfEffect;

    public GameEffects gameEffects { get; set;}

    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        typeOfEffect.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        if (typeOfEffect.text.Length > 30)
        {
            typeOfEffect.fontSize = 78f;
            typeOfEffect.rectTransform.anchoredPosition =
            new Vector2(typeOfEffect.rectTransform.anchoredPosition.x, -70f);
        }
        else
        {
            typeOfEffect.fontSize = 98f;
            typeOfEffect.rectTransform.anchoredPosition =
            new Vector2(typeOfEffect.rectTransform.anchoredPosition.x, -150f);
        }
    
    }

}
