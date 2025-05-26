using TMPro;
using UnityEngine;

public class NeverHaveiever : MonoBehaviour
{
    public TextMeshProUGUI neverHaveIever;
    public TextMeshProUGUI haveEffect;
    public TextMeshProUGUI haveNotEffect;
    public GameEffects gameEffects;

    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        int index = Random.Range(0, gameEffects.badEffects.Count);
        haveNotEffect.text = gameEffects.badEffects[index];
        if (gameEffects.badEffects[index].Length > 30)
        {
            haveNotEffect.fontSize = 65f;

        }
        else
        {
            haveNotEffect.fontSize = 80f;
        }

        int index2 = Random.Range(0, gameEffects.goodEffects.Count);
        haveEffect.text = gameEffects.goodEffects[index2];
        if (gameEffects.goodEffects[index2].Length > 30)
        {
            haveEffect.fontSize = 65;
        }
        else
        {
            haveEffect.fontSize = 80f;
        }
        


    }
}


