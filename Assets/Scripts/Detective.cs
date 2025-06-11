using TMPro;
using UnityEngine;

public class Detective : MonoBehaviour
{
    public GameEffects gameEffects;
    public TextMeshProUGUI description;
    public TextMeshProUGUI amount;
    public TextMeshProUGUI succeful;

    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        description.text = gameEffects.GenerateRandomEffect(gameEffects.detective);
        succeful.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        if (succeful.text.Length > 30)
        {
            succeful.fontSize = 53f;

        }
        else
        {
            succeful.fontSize = 68f;
        }

        amount.text = Random.Range(5, 9).ToString();
    }
}
