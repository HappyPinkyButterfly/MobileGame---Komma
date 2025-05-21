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
        int index = Random.Range(0, gameEffects.badEffects.Count);
        typeOfEffect.text = gameEffects.badEffects[index];
        if (gameEffects.badEffects[index].Length > 30)
        {
            typeOfEffect.fontSize = 80f;
            typeOfEffect.rectTransform.anchoredPosition =
            new Vector2(typeOfEffect.rectTransform.anchoredPosition.x, -70f);
        }
        else
        {
            typeOfEffect.fontSize = 100f;
            typeOfEffect.rectTransform.anchoredPosition =
            new Vector2(typeOfEffect.rectTransform.anchoredPosition.x, -150f);
        }
    
    }

}
