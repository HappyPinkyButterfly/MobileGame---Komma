using TMPro;
using UnityEngine;

public class Mexican : MonoBehaviour
{
    public GameEffects gameEffects;
    public TextMeshProUGUI two;
    public TextMeshProUGUI three;


    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        two.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        if (two.text.Length > 30)
        {
            two.fontSize = 58f;

        }
        else
        {
            two.fontSize = 88f;
        }

        three.text = gameEffects.GenerateRandomEffect(gameEffects.goodEffects);
        if (three.text.Length > 30)
        {
            three.fontSize = 58f;
        }
        else
        {
            three.fontSize = 88f;
        }

        
        
        

    }
}
