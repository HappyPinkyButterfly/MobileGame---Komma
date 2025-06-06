using TMPro;
using UnityEngine;

public class DrinkCounter : MonoBehaviour
{
    public CanvasGroup plusMinus;

    public TextMeshProUGUI counter;

    public int maxCounter = 4;
    public int minCounter = -2;

    public void Start()
    {
        counter.text = "0";
    }

    public void PlusClick()
    {

    }
    public void MinusClick()
    {

    }
    public void RestOfTheGameClick()
    {
        
    }
}
