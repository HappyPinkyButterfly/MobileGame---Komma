using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MostLikely : MonoBehaviour
{
    public TextMeshProUGUI effect;
    public TextMeshProUGUI description;
    public GameEffects gameEffects { get; set;}
    public void Awake()
    {
        gameEffects = GetComponentInParent<GameEffects>();
    }

    public void Start()
    {
        description.text = gameEffects.GenerateRandomEffect(gameEffects.descriptionList);
        effect.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        
    }
}
