using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Mastermind : MonoBehaviour
{
    public GameEffects gameEffects;
    public TextMeshProUGUI howMany;
    public TextMeshProUGUI one;
    public TextMeshProUGUI two;
    public TextMeshProUGUI three;
    public TextMeshProUGUI four;

    public void Start()
    {
        howMany.text = Random.Range(2, 5).ToString();

        gameEffects = GetComponentInParent<GameEffects>();

        List<int> allIndexes = Enumerable.Range(0, gameEffects.badEffects.Count).ToList();
        allIndexes = allIndexes.OrderBy(i => Random.value).ToList(); // Shuffle the list

        int index = allIndexes[0];
        int index2 = allIndexes[1];
        int index3 = allIndexes[2];
        int index4 = allIndexes[3];

        one.text = gameEffects.badEffects[index];
        two.text = gameEffects.badEffects[index2];
        three.text = gameEffects.badEffects[index3];
        four.text = gameEffects.badEffects[index4];
        if (gameEffects.badEffects[index].Length > 30)
        {
            one.fontSize = 50f;

        }
        else
        {
            one.fontSize = 65f;
        }

        if (gameEffects.badEffects[index2].Length > 30)
        {
            two.fontSize = 50f;

        }
        else
        {
            two.fontSize = 65f;
        }

        if (gameEffects.badEffects[index3].Length > 30)
        {
            three.fontSize = 50f;

        }
        else
        {
            three.fontSize = 65f;
        }

        if (gameEffects.badEffects[index4].Length > 30)
        {
            four.fontSize = 50f;

        }
        else
        {
            four.fontSize = 65f;
        }

        
    }
}
