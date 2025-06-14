using TMPro;
using UnityEngine;

public class NeverHaveiever : MonoBehaviour
{
    public TextMeshProUGUI neverHaveIever;
    public TextMeshProUGUI haveEffect;
    public TextMeshProUGUI haveNotEffect;
    public GameEffects gameEffects { get; set;}

    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
 
        haveNotEffect.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        if (haveNotEffect.text.Length > 30)
        {
            haveNotEffect.fontSize = 63f;

        }
        else
        {
            haveNotEffect.fontSize = 78f;
        }

        haveEffect.text = gameEffects.GenerateRandomEffect(gameEffects.goodEffects);
        if (haveEffect.text.Length > 30)
        {
            haveEffect.fontSize = 63f;
        }
        else
        {
            haveEffect.fontSize = 78f;
        }

        neverHaveIever.text = gameEffects.GenerateRandomEffect(gameEffects.neverHaveIever);



    }
}


