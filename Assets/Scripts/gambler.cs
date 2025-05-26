using TMPro;
using UnityEngine;

public class gambler : MonoBehaviour
{
    public GameEffects gameEffects;
    public TextMeshProUGUI coorectEffect;

    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        int index = Random.Range(0, gameEffects.goodEffects.Count);
        coorectEffect.text = gameEffects.goodEffects[index];
        if (gameEffects.goodEffects[index].Length > 30)
        {
            coorectEffect.fontSize = 60f;

        }
        else
        {
            coorectEffect.fontSize = 90f;
        }

    }
}
