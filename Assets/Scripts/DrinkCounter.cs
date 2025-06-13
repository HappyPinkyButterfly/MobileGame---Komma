using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DrinkCounter : MonoBehaviour
{
    public CanvasGroup plusMinus;

    public TextMeshProUGUI counter;

    public int maxCounter;
    public int minCounter;

    public int currentCounter = 0;

    public bool popUpOpened = false;
    public Image roundStart;

    public void Start()
    {
        maxCounter = 3;
        minCounter = -1;

        counter.text = currentCounter.ToString();
        plusMinus.alpha = 0f;
        plusMinus.interactable = false;
        plusMinus.blocksRaycasts = false;
    }

    public void PlusClick()
    {
        currentCounter++;
        if (currentCounter < 0)
        {
            counter.text = currentCounter.ToString();

        }
        else if (currentCounter == maxCounter)
        {
            counter.text = "+" + currentCounter.ToString();
            counter.color = Color.red;
            return;

        }
        else if (currentCounter > maxCounter)
        {
            currentCounter = 0;
            counter.text = currentCounter.ToString();
            counter.color = Color.black;
            return;
        }
        else if (currentCounter == 0)
        {
            counter.text = currentCounter.ToString();
        }
        else
        {
            counter.text = "+" + currentCounter.ToString();
        }
        counter.color = Color.black;
        

    }

    public void MinusClick()
    {
        currentCounter--;

        if (currentCounter == minCounter)
        {
            counter.text = currentCounter.ToString();
            counter.color = Color.red;
            return;
        }
        else if(currentCounter < minCounter)
        {
            currentCounter = 0;
            counter.text = currentCounter.ToString();
            counter.color = Color.black;
            return;
        }
        else if (currentCounter < 0)
        {
            counter.text = currentCounter.ToString();

        }
        else if (currentCounter == 0)
        {
            counter.text = currentCounter.ToString();
        }
        else
        {
            counter.text = currentCounter.ToString();
        }
        counter.color = Color.black;   
    }
    public void RestOfTheGameClick()
    {
        if (!popUpOpened)
        {
            plusMinus.alpha = 1f;
            plusMinus.interactable = true;
            plusMinus.blocksRaycasts = true;
            popUpOpened = !popUpOpened;
        }
        else
        {
            plusMinus.alpha = 0f;
            plusMinus.interactable = false;
            plusMinus.blocksRaycasts = false;
            popUpOpened = !popUpOpened;
        }

    }
}
