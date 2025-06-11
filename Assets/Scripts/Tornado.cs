using TMPro;
using UnityEngine;

public class Tornado : MonoBehaviour
{
    public GameEffects gameEffects { get; set; }
    public TextMeshProUGUI first;
    public TextMeshProUGUI second;

    public void Start()
    {

        gameEffects = GetComponentInParent<GameEffects>();

        first.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        second.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);

        if (first.text.Length > 30)
        {
            first.fontSize = 50f;

        }
        else
        {
            first.fontSize = 60f;
        }

        if (second.text.Length > 30)
        {
            second.fontSize = 50f;

        }
        else
        {
            second.fontSize = 60f;
        }
    }
}
