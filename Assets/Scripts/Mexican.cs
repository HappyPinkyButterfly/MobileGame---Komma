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
            two.fontSize = 58f;

        }
        else
        {
            two.fontSize = 88f;
        }

        int index2 = Random.Range(0, gameEffects.goodEffects.Count);
        three.text = gameEffects.goodEffects[index2];
        if (gameEffects.goodEffects[index2].Length > 30)
        {
            three.fontSize = 58f;
        }
        else
        {
            three.fontSize = 88f;
        }

        int index3 = Random.Range(0, gameEffects.badEffects.Count);
        four.text = gameEffects.badEffects[index3];
        if (gameEffects.badEffects[index2].Length > 30)
        {
            four.fontSize = 58f;
        }
        else
        {
            four.fontSize = 88f;
        }
        
        

    }
}
