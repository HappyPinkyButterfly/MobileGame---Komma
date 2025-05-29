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

        //shot.color = Color.red;
        //bottomsUp.color = Color.red;
        //mustache.color = Color.red;
        //kingsCup.color = Color.red;
        //slammer.color = Color.red;

    }

    public void ShotClick()
    {
        if (!shotOn)
        {
            shotOn = true;
            //shot.color = Color.green;
        }
        else
        {
            shotOn = false;
            //shot.color = Color.red;
        }

    }
    public void BottomsUpClick()
    {
        if (!bottomsUpOn)
        {
            bottomsUpOn = true;
           // bottomsUp.color = Color.green;
        }
        else
        {
            bottomsUpOn = false;
           // bottomsUp.color = Color.red;
        }

    }
    public void MustacheClick()
    {
        if (!mustacheOn)
        {
            mustacheOn = true;
            //mustache.color = Color.green;
        }
        else
        {
            mustacheOn = false;
            //mustache.color = Color.red;
        }

    }

    public void KingsCupClick()
    {
        if (!mustacheOn)
        {
            kingsCupOn = true;
            //kingsCup.color = Color.green;
        }
        else
        {
            mustacheOn = false;
            //kingsCup.color = Color.red;
        }

    }

    public void SlammerClick()
    {
        if (!slammerOn)
        {
            slammerOn = true;
            //slammer.color = Color.green;
        }
        else
        {
            slammerOn = false;
            //slammer.color = Color.red;
        }

    }
    
}
