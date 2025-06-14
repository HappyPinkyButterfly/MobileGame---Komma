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
            typeOfEffect.fontSize = 100f;
        }
        else
        {
            typeOfEffect.fontSize = 120f;
        }
    
    }

}
