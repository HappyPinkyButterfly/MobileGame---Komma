using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Mastermind : MonoBehaviour
{
    public GameEffects gameEffects;
    public TextMeshProUGUI howMany;
    public TextMeshProUGUI one;
    public TextMeshProUGUI two;
    public TextMeshProUGUI three;
    public TextMeshProUGUI four;

    public void Start()
    {
        howMany.text = Random.Range(2, 5).ToString();

        gameEffects = GetComponentInParent<GameEffects>();

        one.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        two.text =gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        three.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        four.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        
        if (one.text.Length > 30)
        {
            one.fontSize = 48f;

        }
        else
        {
            one.fontSize = 63f;
        }

        if (two.text.Length > 30)
        {
            two.fontSize = 48f;

        }
        else
        {
            two.fontSize = 63f;
        }

        if (three.text.Length > 30)
        {
            three.fontSize = 48f;

        }
        else
        {
            three.fontSize = 63f;
        }

        if (four.text.Length > 30)
        {
            four.fontSize = 48f;

        }
        else
        {
            four.fontSize = 63f;
        }

        
    }
}
