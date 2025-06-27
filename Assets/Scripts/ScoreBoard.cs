using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public CanvasGroup popupScoreBoard;
    public TextMeshProUGUI points;
    public TextMeshProUGUI pointsToAddText;
    private int pointsToWin = 100;

    private int pointsToAdd = 0;
    private int maxPointsToAdd = 7;

    public CanvasGroup score;
    public GameEffects gameEffects;
    public CanvasGroup youWin;

    public int currentPoints;

    public void Awake()
    {
        if (gameEffects.competitiveState)
        {
            score.alpha = 1f;
            score.interactable = true;
            score.blocksRaycasts = true;
        }
        else
        {
            score.alpha = 0f;
            score.interactable = false;
            score.blocksRaycasts = false;
        }

        currentPoints = 0;
        points.text = currentPoints.ToString();

        popupScoreBoard.alpha = 0f;
        popupScoreBoard.interactable = false;
        popupScoreBoard.blocksRaycasts = false;

        pointsToAddText.text = pointsToAdd.ToString();

        youWin.alpha = 0f;
        youWin.interactable = false;
        youWin.blocksRaycasts = false;
    }

    public void Confirm()
    {
        pointsToAdd = 0;
        pointsToAddText.text = pointsToAdd.ToString();
        popupScoreBoard.alpha = 0f;
        popupScoreBoard.interactable = false;
        popupScoreBoard.blocksRaycasts = false;
    }

    public void Points()
    {
        popupScoreBoard.alpha = 1f;
        popupScoreBoard.interactable = true;
        popupScoreBoard.blocksRaycasts = true;
        if (currentPoints >= pointsToWin)
        {
            YouWin();
        }
    }


    public void YouWin()
    {
        popupScoreBoard.alpha = 0f;
        popupScoreBoard.interactable = false;
        popupScoreBoard.blocksRaycasts = false;

        youWin.alpha = 1f;
        youWin.interactable = true;
        youWin.blocksRaycasts = true;
    }
    
    public void YouWinClick()
    {
        youWin.alpha = 0f;
        youWin.interactable = false;
        youWin.blocksRaycasts = false;
    }

    public void PlusPointsClick()
    {
        pointsToAdd++;
        if (pointsToAdd > maxPointsToAdd)
        {
            pointsToAdd = 0;
        }
        pointsToAddText.text = pointsToAdd.ToString();

    }
    public void MinusPointsClick()
    {
        pointsToAdd--;
        if (pointsToAdd < 0)
        {
            pointsToAdd = 0;
        }
        pointsToAddText.text = pointsToAdd.ToString();
    }
    public void AddPointsClick()
    {
        currentPoints += pointsToAdd;
        points.text = currentPoints.ToString();
        if (currentPoints >= pointsToWin)
        {
            YouWin();
        }
        pointsToAdd = 0;
        pointsToAddText.text = pointsToAdd.ToString();

    }
    
    
}
