using TMPro;
using UnityEngine;

public class Photographer : MonoBehaviour
{
    public GameEffects gameEffects { get; set;}
    public TextMeshProUGUI whatKind;

     public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        whatKind.text = gameEffects.GenerateRandomEffect(gameEffects.photographer);
    }
}
