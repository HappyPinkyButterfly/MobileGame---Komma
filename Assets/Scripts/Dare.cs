using TMPro;
using UnityEngine;

public class Dare : MonoBehaviour
{
    public GameEffects gameEffects { get; set; }
    public TextMeshProUGUI challenge;

    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        challenge.text = gameEffects.GenerateRandomEffect(gameEffects.dare);
    }
}
