using TMPro;
using UnityEngine;

public class Mexican : MonoBehaviour
{
    public GameEffects gameEffects { get; set;}
    public TextMeshProUGUI two;



    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        two.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        if (two.text.Length > 30)
        {
            two.fontSize = 78f;

        }
        else
        {
            two.fontSize = 88f;
        }


    }
}
