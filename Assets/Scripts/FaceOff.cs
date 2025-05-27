using TMPro;
using UnityEngine;

public class FaceOff : MonoBehaviour
{
    public GameEffects gameEffects;
    public TextMeshProUGUI wrongEffect;
    public TextMeshProUGUI whoYouBattle;

    public TextMeshProUGUI distance;

    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        int index = Random.Range(0, gameEffects.badEffects.Count);
        wrongEffect.text = gameEffects.badEffects[index];
        if (gameEffects.badEffects[index].Length > 30)
        {
            wrongEffect.fontSize = 80f;

        }
        else
        {
            wrongEffect.fontSize = 100f;
        }

        int index2 = Random.Range(0, gameEffects.contestTypes.Count);
        whoYouBattle.text = gameEffects.contestTypes[index2];

        int index3 = Random.Range(0, gameEffects.faceOffWho.Count);
        distance.text = gameEffects.faceOffWho[index3];



    }
}
