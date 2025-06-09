using UnityEngine;
using UnityEngine.UI;

public class Prefrences : MonoBehaviour
{
    public Image shot;
    public Image bottomsUp;
    public Image mustache;
    public Image kingsCup;
    public Image slammer;
    public Image competitive;
    public Image action;

    public Sprite GreenShot;
    public Sprite RedShot;
    public Sprite GreenKingsCup;
    public Sprite RedKingsCup;
    public Sprite GreenSlammer;
    public Sprite RedSlammer;
    public Sprite GreenMustache;
    public Sprite RedMustache;
    public Sprite GreenBottomsUp;
    public Sprite RedBottomsUp;

    public Sprite GreenCompetitive;
    public Sprite RedCompetitive;

    public Sprite GreenAction;
    public Sprite RedAction;

    public CanvasGroup popUp;
    public CanvasGroup popUpAction;



    public bool mustacheOn = false;
    public bool bottomsUpOn = false;
    public bool shotOn = false;
    public bool kingsCupOn = false;
    public bool slammerOn = false;
    public bool competitiveOn = false;
    public bool actionOn = false;


    public static Prefrences Instance;

    public void Awake()
    {
        popUp.alpha = 0f;
        popUp.interactable = false;
        popUp.blocksRaycasts = false;

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Objekt ostane med scenami
        }
        else
        {
            Destroy(gameObject); // Prepreči podvajanje
        }

        shot.sprite = RedShot;
        bottomsUp.sprite = RedBottomsUp;
        mustache.sprite = RedMustache;
        kingsCup.sprite = RedKingsCup;
        slammer.sprite = RedSlammer;

    }
    public void YesClick()
    {
        mustacheOn = true;
        bottomsUpOn = true;
        shotOn = true;
        kingsCupOn = true;
        slammerOn = true;
        competitiveOn = true;

        shot.sprite = GreenShot;
        bottomsUp.sprite = GreenBottomsUp;
        mustache.sprite = GreenMustache;
        kingsCup.sprite = GreenKingsCup;
        slammer.sprite = GreenSlammer;
        competitive.sprite = GreenCompetitive;

        popUp.alpha = 0f;
        popUp.interactable = false;
        popUp.blocksRaycasts = false;
    }

    public void NoClick()
    {
        popUp.alpha = 0f;
        popUp.interactable = false;
        popUp.blocksRaycasts = false;
    }

    public void CompetitiveClick()
    {
        if (!competitiveOn)
        {
            popUp.alpha = 1f;
            popUp.interactable = true;
            popUp.blocksRaycasts = true;
        }
        else
        {
            competitiveOn = false;
            competitive.sprite = RedCompetitive;
        }
    }

    public void ActionYesClick()
    {
        actionOn = true;
        popUpAction.alpha = 0f;
        popUpAction.interactable = false;
        popUpAction.blocksRaycasts = false;
        action.sprite = GreenAction;
    }

    public void ActionNoClick()
    {
        popUpAction.alpha = 0f;
        popUpAction.interactable = false;
        popUpAction.blocksRaycasts = false;
    }

    public void ActionClick()
    {
        if (!actionOn)
        {
            popUpAction.alpha = 1f;
            popUpAction.interactable = true;
            popUpAction.blocksRaycasts = true;
        }
        else
        {
            actionOn = false;
            action.sprite = RedAction;
        }

    }

    public void ShotClick()
    {
        if (!shotOn)
        {
            shotOn = true;
            shot.sprite = GreenShot;
        }
        else
        {
            shotOn = false;
            shot.sprite = RedShot;

            competitiveOn = false;
            competitive.sprite = RedCompetitive;
        }

    }
    public void BottomsUpClick()
    {
        if (!bottomsUpOn)
        {
            bottomsUpOn = true;
            bottomsUp.sprite = GreenBottomsUp;
        }
        else
        {
            bottomsUpOn = false;
            bottomsUp.sprite = RedBottomsUp;

            competitiveOn = false;
            competitive.sprite = RedCompetitive;
        }

    }
    public void MustacheClick()
    {
        if (!mustacheOn)
        {
            mustacheOn = true;
            mustache.sprite = GreenMustache;
        }
        else
        {
            mustacheOn = false;
            mustache.sprite = RedMustache;

            competitiveOn = false;
            competitive.sprite = RedCompetitive;
        }

    }

    public void KingsCupClick()
    {
        if (!kingsCupOn)
        {
            kingsCupOn = true;
            kingsCup.sprite = GreenKingsCup;
        }
        else
        {
            kingsCupOn = false;
            kingsCup.sprite = RedKingsCup;

            competitiveOn = false;
            competitive.sprite = RedCompetitive;
        }

    }

    public void SlammerClick()
    {
        if (!slammerOn)
        {
            slammerOn = true;
            slammer.sprite = GreenSlammer;
        }
        else
        {
            slammerOn = false;
            slammer.sprite = RedSlammer;

            competitiveOn = false;
            competitive.sprite = RedCompetitive;
        }
    }
}
