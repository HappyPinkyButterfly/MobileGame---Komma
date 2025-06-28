using TMPro;
using UnityEngine;

public class Wish : MonoBehaviour
{
    public GameEffects gameEffects { get; set;}
    public TextMeshProUGUI one;
    public TextMeshProUGUI two;
    public TextMeshProUGUI three;
    public TextMeshProUGUI four;

    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();

        one.text = gameEffects.GenerateRandomEffect(gameEffects.goodEffects);
        two.text =gameEffects.GenerateRandomEffect(gameEffects.goodEffects);
        three.text = gameEffects.GenerateRandomEffect(gameEffects.goodEffects);
        four.text = gameEffects.GenerateRandomEffect(gameEffects.goodEffects);
        
        if (one.text.Length > 30)
        {
            one.fontSize = 47f + gameEffects.fontControlSmall;

        }
        else
        {
            one.fontSize = 57f + gameEffects.fontControlBig;
        }

        if (two.text.Length > 30)
        {
            two.fontSize = 47f  + gameEffects.fontControlSmall;

        }
        else
        {
            two.fontSize = 57f + gameEffects.fontControlBig;
        }

        if (three.text.Length > 30)
        {
            three.fontSize = 47f + gameEffects.fontControlSmall;

        }
        else
        {
            three.fontSize = 57f + gameEffects.fontControlBig;
        }

        if (four.text.Length > 30)
        {
            four.fontSize = 47f + gameEffects.fontControlSmall;

        }
        else
        {
            four.fontSize = 57f + gameEffects.fontControlBig;
        }

        
    }
}
