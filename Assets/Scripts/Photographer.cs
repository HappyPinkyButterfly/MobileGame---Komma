using TMPro;
using UnityEngine;

public class Photographer : MonoBehaviour
{
    public GameEffects gameEffects;
    public TextMeshProUGUI whatKind;

     public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        int index = Random.Range(0, gameEffects.photographer.Count);
        whatKind.text = gameEffects.photographer[index];
    }
}
