using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class RoundStart : MonoBehaviour
{
    public TextMeshProUGUI typeOfEffect;
    public TextMeshProUGUI amount;
    public TextMeshProUGUI typeOfDrinking;
    public TextMeshProUGUI sideEffect;
    public TextMeshProUGUI sideAmounts;

    public List<string> typeOfEffectList = new List<string>
    {
        "TAKE",
        "GIVE",
        "TAKE AND GIVE",
        "EVERYONE",
        "EVERYONE ELSE",
        "SAME GENDER"
    };

    public List<string> typeOfDrinkingTable = new List<string>
    {
        "Sips",
        "Second\nChug"
    };

    public void RoundStartClick()
    {
        int index = Random.Range(0, typeOfEffectList.Count);
        int index2 = Random.Range(0, typeOfDrinkingTable.Count);
        typeOfEffect.text = typeOfEffectList[index];
        typeOfDrinking.text =typeOfDrinkingTable[index2];
    }
}
