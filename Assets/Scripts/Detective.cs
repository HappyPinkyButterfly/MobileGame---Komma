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
        int index = Random.Range(0, gameEffects.detective.Count);
        description.text = gameEffects.detective[index];

        int index2 = Random.Range(0, gameEffects.goodEffects.Count);
        succeful.text = gameEffects.badEffects[index2];
        if (gameEffects.badEffects[index2].Length > 30)
        {
            succeful.fontSize = 55f;

        }
        else
        {
            succeful.fontSize = 70f;
        }

        amount.text = Random.Range(5, 9).ToString();
    }
}
