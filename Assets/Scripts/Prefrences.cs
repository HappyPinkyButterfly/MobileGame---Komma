using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Prefrences : MonoBehaviour
{
    public Image shot;
    public Image bottomsUp;
    public Image mustache;
    public Image kingsCup;
    public Image slammer;

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
    


    public bool mustacheOn = false;
    public bool bottomsUpOn = false;
    public bool shotOn = false;
    public bool kingsCupOn = false;
    public bool slammerOn = false;
    public static Prefrences Instance;

    public void Awake()
    {
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
        //slammer.color = Color.red;

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
        }

    }
    
}
