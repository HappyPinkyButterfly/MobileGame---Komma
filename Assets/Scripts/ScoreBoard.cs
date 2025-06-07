using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public CanvasGroup popupScoreBoard;
    public TextMeshProUGUI points;
    private int pointsToWin = 20;

    public CanvasGroup youwin;


    public CanvasGroup king;
    public CanvasGroup shot;

    public CanvasGroup bottomsUp;
    public CanvasGroup score;
    public GameEffects gameEffects;



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

        youwin.alpha = 0f;
        youwin.interactable = false;
        youwin.blocksRaycasts = false;

        king.alpha = 1f;
        king.interactable = true;
        king.blocksRaycasts = true;

        shot.alpha = 1f;
        shot.interactable = true;
        shot.blocksRaycasts = true;

        bottomsUp.alpha = 1f;
        bottomsUp.interactable = true;
        bottomsUp.blocksRaycasts = true;
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

    public void KingsCupPoints()
    {
        currentPoints++;
        currentPoints++;
        currentPoints++;
        points.text = currentPoints.ToString();

        if (currentPoints >= pointsToWin)
        {
            YouWin();
        }
    }

    public void ShotSlamemrPoints()
    {
        currentPoints++;
        currentPoints++;
        points.text = currentPoints.ToString();

        if (currentPoints >= pointsToWin)
        {
            YouWin();
        }
    }

    public void BottomsUpPoints()
    {
        currentPoints++;
        points.text = currentPoints.ToString();

        if (currentPoints >= pointsToWin)
        {
            YouWin();
        }

    }

    public void YouWin()
    {
        king.alpha = 0f;
        king.interactable = false;
        king.blocksRaycasts = false;

        shot.alpha = 0f;
        shot.interactable = false;
        shot.blocksRaycasts = false;

        bottomsUp.alpha = 0f;
        bottomsUp.interactable = false;
        bottomsUp.blocksRaycasts = false;

        youwin.alpha = 1f;
        youwin.interactable = true;
        youwin.blocksRaycasts = true;
    }
    
    
}
