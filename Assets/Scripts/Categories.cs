using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Categories : MonoBehaviour
{
    public TextMeshProUGUI typeOfEffect;


    [SerializeField]
    public List<string> typeOfEffectList2;

    public void Start()
    {
        typeOfEffectList2 = new List<string>
        {
        "Draw 3 Round Starts",
        "Draw 2 Round Starts",
        "Take 6 Sips",
        "Take 5 Sips",
        "Take 4 Sips",
        "Take 3 Sips",
        "Chug 5 Seconds",
        "Chug 4 Seconds",
        "Chug 3 Seconds",
        "Take SHOT",
        "Bottoms Up"
        };
        
        int index = Random.Range(0, typeOfEffectList2.Count);
        typeOfEffect.text = typeOfEffectList2[index];
    }

}
