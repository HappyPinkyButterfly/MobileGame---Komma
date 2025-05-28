using TMPro;
using UnityEngine;

public class Detective : MonoBehaviour
{
    public GameEffects gameEffects;
    public TextMeshProUGUI description;

    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        int index = Random.Range(0, gameEffects.detective.Count);
        description.text = gameEffects.detective[index];
    }
}
