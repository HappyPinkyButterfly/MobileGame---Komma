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
            first.fontSize = 50f + gameEffects.fontControlSmall;

        }
        else
        {
            first.fontSize = 60f + gameEffects.fontControlBig;
        }

        if (second.text.Length > 30)
        {
            second.fontSize = 50f + gameEffects.fontControlSmall;

        }
        else
        {
            second.fontSize = 60f + gameEffects.fontControlBig;
        }
    }
}
