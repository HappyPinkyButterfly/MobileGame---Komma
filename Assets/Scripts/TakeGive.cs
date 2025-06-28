using TMPro;
using UnityEngine;

public class TakeGive : MonoBehaviour
{
    public GameEffects gameEffects { get; set; }
    public TextMeshProUGUI takeEffect;
    public TextMeshProUGUI giveEffect;

    public void Start()
    {

        gameEffects = GetComponentInParent<GameEffects>();

        takeEffect.text = gameEffects.GenerateRandomEffect(gameEffects.goodEffects);
        giveEffect.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);

        if (takeEffect.text.Length > 20)
        {
            takeEffect.fontSize = 60f + gameEffects.fontControlSmall;

        }
        else
        {
            takeEffect.fontSize = 70f + gameEffects.fontControlBig;
        }

        if (giveEffect.text.Length > 20)
        {
            giveEffect.fontSize = 60f + gameEffects.fontControlSmall;

        }
        else
        {
            giveEffect.fontSize = 70f + gameEffects.fontControlBig;
        }
    }
}
