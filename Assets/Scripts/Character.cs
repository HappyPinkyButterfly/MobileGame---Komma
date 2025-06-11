using TMPro;
using UnityEngine;

public class Character : MonoBehaviour
{
    public GameEffects gameEffects { get; set; }
    public TextMeshProUGUI one;
    public TextMeshProUGUI two;
    public TextMeshProUGUI three;
    public TextMeshProUGUI oneEffect;
    public TextMeshProUGUI twoEffect;
    public TextMeshProUGUI threeEffect;

    public void Start()
    {

        gameEffects = GetComponentInParent<GameEffects>();

        one.text = gameEffects.GenerateRandomEffect(gameEffects.sideEffectList);
        two.text = gameEffects.GenerateRandomEffect(gameEffects.sideEffectList);
        three.text = gameEffects.GenerateRandomEffect(gameEffects.sideEffectList);

        oneEffect.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        twoEffect.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        threeEffect.text = gameEffects.GenerateRandomEffect(gameEffects.goodEffects);

        if (one.text.Length > 20)
        {
            one.fontSize = 55f;

        }
        else
        {
            one.fontSize = 65f;
        }

        if (two.text.Length > 20)
        {
            two.fontSize = 55f;

        }
        else
        {
            two.fontSize = 65f;
        }

        if (three.text.Length > 20)
        {
            three.fontSize = 55f;

        }
        else
        {
            three.fontSize = 65f;
        }
        
        if (oneEffect.text.Length > 25)
        {
            oneEffect.fontSize = 55f;

        }
        else
        {
            oneEffect.fontSize = 65f;
        }

        if (twoEffect.text.Length > 25)
        {
            twoEffect.fontSize = 55f;

        }
        else
        {
            twoEffect.fontSize = 65f;
        }

        if (threeEffect.text.Length > 25)
        {
            threeEffect.fontSize = 55f;

        }
        else
        {
            threeEffect.fontSize = 65f;
        }

        


    }
}
