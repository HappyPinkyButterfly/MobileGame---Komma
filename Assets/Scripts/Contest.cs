using TMPro;
using UnityEngine;

public class Contest : MonoBehaviour
{
    public GameEffects gameEffects { get; set;}
    public TextMeshProUGUI closestEffect;
    public TextMeshProUGUI farthestEffect;
    public TextMeshProUGUI type;


    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        closestEffect.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        if (closestEffect.text.Length > 30)
        {
            closestEffect.fontSize = 63f + gameEffects.fontControlSmall;

        }
        else
        {
            closestEffect.fontSize = 88f + gameEffects.fontControlBig;
        }

        farthestEffect.text = gameEffects.GenerateRandomEffect(gameEffects.goodEffects);
        if (farthestEffect.text.Length > 30)
        {
            farthestEffect.fontSize = 63f + gameEffects.fontControlSmall;
        }
        
        else
        {
            farthestEffect.fontSize = 88f + gameEffects.fontControlBig;
        }
        
        int index3 = Random.Range(0, gameEffects.contestTypes.Count);
        type.text = gameEffects.contestTypes[index3];

    }
}
