using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Prefrences : MonoBehaviour
{
    public Image shot;
    public Image bottomsUp;
    public Image mustache;

    public bool mustacheOn = false;
    public bool bottomsUpOn = false;
    public bool shotOn = false;
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

        shot.color = Color.red;
        bottomsUp.color = Color.red;
        mustache.color = Color.red;

    }

    public void ShotClick()
    {
        if (!shotOn)
        {
            shotOn = true;
            shot.color = Color.green;
        }
        else
        {
            shotOn = false;
            shot.color = Color.red;
        }

    }
    public void BottomsUpClick()
    {
        if (!bottomsUpOn)
        {
            bottomsUpOn = true;
            bottomsUp.color = Color.green;
        }
        else
        {
            bottomsUpOn = false;
            bottomsUp.color = Color.red;
        }

    }
    public void MustacheClick()
    {
        if (!mustacheOn)
        {
            mustacheOn = true;
            mustache.color = Color.green;
        }
        else
        {
            mustacheOn = false;
            mustache.color = Color.red;
        }

    }
    // public void Update()
    // {
    //     if (!mustacheOn)
    //     {
    //         ColorBlock mustachee = mustache.colors;
    //         mustachee.normalColor = Color.green;
    //         mustache.colors = mustachee;
    //     }
    //     else
    //     {
    //         ColorBlock mustachee = mustache.colors;
    //         mustachee.normalColor = Color.red;
    //         mustache.colors = mustachee;
    //     }

    //     if (!bottomsUpOn)
    //     {
    //         ColorBlock bottomsUpp = bottomsUp.colors;
    //         bottomsUpp.normalColor = Color.green;
    //         bottomsUp.colors = bottomsUpp;
    //     }
    //     else
    //     {
    //         ColorBlock bottomsUpp = bottomsUp.colors;
    //         bottomsUpp.normalColor = Color.red;
    //         bottomsUp.colors = bottomsUpp;
    //     }

    //     if (!shotOn)
    //     {
    //         ColorBlock shott = shot.colors;
    //         shott.normalColor = Color.green;
    //         shot.colors = shott;
    //     }
    //     else
    //     {
    //         ColorBlock shott = shot.colors;
    //         shott.normalColor = Color.red;
    //         shot.colors = shott;
    //     }
    // }
}
