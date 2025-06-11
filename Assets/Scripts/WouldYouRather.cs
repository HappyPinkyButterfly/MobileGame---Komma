using TMPro;
using UnityEngine;

public class WouldYouRather : MonoBehaviour
{
    public GameEffects gameEffects;
    public TextMeshProUGUI first;
    public TextMeshProUGUI second;
    public TextMeshProUGUI firstEff;
    public TextMeshProUGUI secondEff;


    public void Start()
    {
        if (first.ToString().Length > 20)
        {
            first.fontSize = 60f;

        }
        else
        {
            first.fontSize = 68f;
        }
        if (second.ToString().Length > 20)
        {
            second.fontSize = 60f;

        }
        else
        {
            second.fontSize = 68f;
        }
        
        gameEffects = GetComponentInParent<GameEffects>();
        firstEff.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        if (firstEff.text.Length > 30)
        {
            firstEff.fontSize = 63f;

        }
        else
        {
            firstEff.fontSize = 78f;
        }

        secondEff.text = gameEffects.GenerateRandomEffect(gameEffects.goodEffects);
        if (secondEff.text.Length > 30)
        {
            secondEff.fontSize = 63f;
        }
        else
        {
            secondEff.fontSize = 78f;
        }

        int index3 = Random.Range(0, gameEffects.wouldYouRather1.Count);
        first.text = gameEffects.wouldYouRather1[index3];
        second.text = gameEffects.wouldYouRather2[index3];

    }
}
