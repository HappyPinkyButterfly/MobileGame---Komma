using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class RoundStart : MonoBehaviour
{
    public bool isCompetitiveMode;
    public Image roundStartButton;
    public Sprite roundStartSprite;
    public TextMeshProUGUI typeOfEffect;
    public TextMeshProUGUI amount;
    public TextMeshProUGUI typeOfDrinking;
    public TextMeshProUGUI sideEffect;
    public TextMeshProUGUI sideAmounts;
    public GameEffects gameEffects { get; set;}

    public List<string> typeOfEffectList = new List<string>
    {
        "TAKE",
        "TAKE",
        "TAKE",
        "GIVE",
        "GIVE",
        "GIVE",
        "TAKE AND GIVE",
        "EVERYONE",
        "EVERYONE ELSE",
        "SAME GENDER"
    };

    public List<string> typeOfDrinkingList = new List<string>
    {
        "Sips",
        "Sips",
        "Sips",
        "Second Chug"
    };

    public List<string> sideEffectList = new List<string>
    {
        "Have or been walked on during sex",
        "You are simp",
        "For each bodycount",
        "Virgin",
        "Drinking vodka",
        "Not drinking vodka",
        "Sexy person",
        "Nice person",
        "Hooked up with someone you met online",
        "Had shot",
        "Taken",
        "Been with friends ex",
        "Attracted to present player",
        "Been skinny dipping",
        "Have made selfie last week",
        "Kissed or had sex with present player",
        "Turned on by a fictional character",
        "Ever lost keys or wallet",
        "Ever puked first",
        "For every virgin present",
        "Under 180cm",
        "Over 180cm",
        "For each relationhip",
        "Had body shot",
        "Had condom popped",
        "For each sibling",
        "Used dating apps",
        "Currently using dating apps",
        "For each virtginity taken",
        "Been pregnancy scared",
        "Slept with older"
    };
    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        if (Prefrences.Instance != null)
        {
            isCompetitiveMode = Prefrences.Instance.competitiveOn;

        }
    }

     // Preveri, če Instance obstaja
        
    public void Update()
    {
        if (!gameEffects.roundStart)
        {
            roundStartButton.sprite = roundStartSprite;
            typeOfEffect.text = "";
            amount.text = "";
            typeOfDrinking.text = "";
            sideEffect.text = "";
            sideAmounts.text = "";
        }
        else
        {
            roundStartButton.sprite = null;
            typeOfEffect.rectTransform.anchoredPosition =
            new Vector2(0f, 300f);
        }
    }

    public void RoundStartClick()
    {
        gameEffects.roundStart = true;
        int index = Random.Range(0, typeOfEffectList.Count);
        int index2 = Random.Range(0, typeOfDrinkingList.Count);

        typeOfEffect.text = typeOfEffectList[index];

        if (typeOfEffectList[index] == "TAKE" || typeOfEffectList[index] == "GIVE")
        {
            typeOfEffect.fontSize = 200f;
        }
        else
        {
            typeOfEffect.fontSize = 140f;
        }

        amount.text = Random.Range(1, 3).ToString();

        typeOfDrinking.text = typeOfDrinkingList[index2];

        if (typeOfDrinkingList[index2] == "Second Chug")
        {
            typeOfDrinking.fontSize = 100f;
            amount.rectTransform.anchoredPosition =
            new Vector2(-300f, amount.rectTransform.anchoredPosition.y);
        }
        else
        {
            typeOfDrinking.fontSize = 150f;
            amount.rectTransform.anchoredPosition =
            new Vector2(-150f, amount.rectTransform.anchoredPosition.y);
        }

        int index3 = Random.Range(0, sideEffectList.Count);
        sideEffect.text = sideEffectList[index3];

        if (sideEffectList[index3].Length < 13)
        {
            sideEffect.fontSize = 120;
        }
        else
        {
            sideEffect.fontSize = 90;
        }

       

        sideAmounts.text = " +" + Random.Range(1, 3).ToString();
    }
}

