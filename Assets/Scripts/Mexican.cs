using TMPro;
using UnityEngine;

public class Mexican : MonoBehaviour
{
    public GameEffects gameEffects;
    public TextMeshProUGUI two;
    public TextMeshProUGUI three;
    public TextMeshProUGUI four;


    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        int index = Random.Range(0, gameEffects.badEffects.Count);
        two.text = gameEffects.badEffects[index];
        if (gameEffects.badEffects[index].Length > 30)
        {
            two.fontSize = 70f;

        }
        else
        {
            two.fontSize = 90f;
        }

        int index2 = Random.Range(0, gameEffects.goodEffects.Count);
        three.text = gameEffects.goodEffects[index2];
        if (gameEffects.goodEffects[index2].Length > 30)
        {
            three.fontSize = 70f;
        }
        else
        {
            three.fontSize = 90f;
        }

        int index3 = Random.Range(0, gameEffects.badEffects.Count);
        four.text = gameEffects.badEffects[index3];
        if (gameEffects.badEffects[index2].Length > 30)
        {
            four.fontSize = 70f;
        }
        else
        {
            four.fontSize = 90f;
        }
        
        

    }
}
