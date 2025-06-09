using TMPro;
using UnityEngine;

public class Contest : MonoBehaviour
{
    public GameEffects gameEffects;
    public TextMeshProUGUI closestEffect;
    public TextMeshProUGUI farthestEffect;
    public TextMeshProUGUI type;


    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        int index = Random.Range(0, gameEffects.badEffects.Count);
        closestEffect.text = gameEffects.badEffects[index];
        if (gameEffects.badEffects[index].Length > 30)
        {
            closestEffect.fontSize = 63f;

        }
        else
        {
            closestEffect.fontSize = 88f;
        }

        int index2 = Random.Range(0, gameEffects.goodEffects.Count);
        farthestEffect.text = gameEffects.goodEffects[index2];
        if (gameEffects.goodEffects[index2].Length > 30)
        {
            farthestEffect.fontSize = 63f;
        }
        
        else
        {
            farthestEffect.fontSize = 88f;
        }
        
        int index3 = Random.Range(0, gameEffects.contestTypes.Count);
        type.text = gameEffects.contestTypes[index3];

    }
}
