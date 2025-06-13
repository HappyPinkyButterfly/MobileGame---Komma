using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class RoundStartComp2 : MonoBehaviour
{
    public bool isCompetitiveMode;
    public RectTransform roundStart;
    public Image roundStartButton;
    public Sprite roundStartSprite;
    public Sprite roundStartSpritePlay;
    public TextMeshProUGUI typeOfEffect;
    public TextMeshProUGUI amount;
    public TextMeshProUGUI typeOfDrinking;
    public TextMeshProUGUI sideEffect;
    public TextMeshProUGUI sideAmounts;
    public GameEffects gameEffects { get; set; }
    public  List<string> usedEffects;
    
    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        if (Prefrences.Instance != null)
        {
            isCompetitiveMode = Prefrences.Instance.competitiveOn;

        }

        roundStart.sizeDelta = new Vector2(950f, 800);

    }
    public void Reset()
    {
        roundStartButton.sprite = roundStartSprite;
        typeOfEffect.text = "";
        amount.text = "";
        typeOfDrinking.text = "";
        sideEffect.text = "";
        sideAmounts.text = "";
        roundStart.sizeDelta = new Vector2(950f, 800f);
    }



    public void RoundStartClick()
    {
        int amountNumber; 
        roundStart.sizeDelta = new Vector2(1000f, 900f);
        roundStartButton.sprite = roundStartSpritePlay;
        gameEffects.roundStart = true;
        int index = Random.Range(0, gameEffects.typeOfEffectList.Count);
        int index2 = Random.Range(0, gameEffects.typeOfDrinkingList.Count);

        typeOfEffect.text = gameEffects.typeOfEffectList[index];

        if (gameEffects.typeOfEffectList[index] == "TAKE" || gameEffects.typeOfEffectList[index] == "GIVE")
        {
            typeOfEffect.fontSize = 160f;
        }
        else
        {
            typeOfEffect.fontSize = 112f;
        }
        amountNumber = Random.Range(1, 3) + gameEffects.drinkCounter.currentCounter;
        amount.text = amountNumber.ToString();

        typeOfDrinking.text = gameEffects.typeOfDrinkingList[index2];

        if (gameEffects.typeOfDrinkingList[index2] == "Second Chug")
        {
            typeOfDrinking.fontSize = 80f;
            amount.rectTransform.anchoredPosition =
            new Vector2(-300f, amount.rectTransform.anchoredPosition.y);
        }
        else
        {
            typeOfDrinking.fontSize = 120f;
            amount.rectTransform.anchoredPosition =
            new Vector2(-150f, amount.rectTransform.anchoredPosition.y);
        }

        
        sideEffect.text = gameEffects.GenerateRandomEffect(gameEffects.sideEffectList);

        if (sideEffect.text.Length < 13)
        {
            sideEffect.fontSize = 96f;
        }
        else
        {
            sideEffect.fontSize = 69f;
        }

        sideAmounts.text = " +" + Random.Range(1, 3).ToString();
    }
}

