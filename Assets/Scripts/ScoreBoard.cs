using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public CanvasGroup popupScoreBoard;
    public TextMeshProUGUI points;
    private int pointsToWin = 20;
    

    public int currentPoints;

    public void Awake()
    {
        currentPoints = 0;
        points.text = currentPoints.ToString();

        popupScoreBoard.alpha = 0f;
        popupScoreBoard.interactable = false;
        popupScoreBoard.blocksRaycasts = false;
    }

    public void PlusSign()
    {
        currentPoints++;
        points.text = currentPoints.ToString();

        if (currentPoints >= pointsToWin)
        {
            currentPoints = pointsToWin;
            points.text = currentPoints.ToString();
        }
        
        if (currentPoints == pointsToWin)
        { }
    }
    public void MinusSign()
    {
        currentPoints--;
        points.text = currentPoints.ToString(); 
        if (currentPoints <= 0)
        {
            currentPoints = 0;
            points.text = currentPoints.ToString();
        }
    }

    public void Confirm()
    {
        popupScoreBoard.alpha = 0f;
        popupScoreBoard.interactable = false;
        popupScoreBoard.blocksRaycasts = false;
    }

    public void Points()
    {
        popupScoreBoard.alpha = 1f;
        popupScoreBoard.interactable = true;
        popupScoreBoard.blocksRaycasts = true; 
    }
}
