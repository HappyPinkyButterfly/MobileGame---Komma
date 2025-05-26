using System.Collections.Generic;
using UnityEngine;

public class GameEffects : MonoBehaviour
{
    public List<string> badEffects;
    public List<string> goodEffects;
    public List<string> contestTypes;
    public List<string> descriptionList;
    public List<string> truth;

    public void Awake()
    {
        badEffects = new List<string>
        {
            "All diffrent genders take a photo with you and 5 sips",
            "Take sips equal to the continets you visited",
            "Draw Round Start for each player present",
            "Take photo with the youngest player, make cute faces and SHOT",
            "Draw 3 Round Starts",
            "Draw 2 Round Starts",
            "Take 6 Sips",
            "Take 5 Sips",
            "Take 4 Sips",
            "Take 3 Sips",
            "Chug 5 Seconds",
            "Chug 4 Seconds",
            "Chug 3 Seconds",
            "Take SHOT",
            "Bottoms Up",
            "Draw Round Starts equal to your bodycount"
        };

        goodEffects = new List<string>
        {
            "Give 3 Round Starts",
            "Give 2 Round Starts",
            "Give 6 Sips",
            "Give 5 Sips",
            "Give 4 Sips",
            "Give 3 Sips",
            "Give Chug 5 Seconds",
            "Give Chug 4 Seconds",
            "Give Chug 3 Seconds",
            "Give SHOT",
            "Give Bottoms Up",
            "All diffrent genders take a photo with you and give 5 sips",
            "Give sips equal to the continets you visited",
            "Give Round Start for each player present",

        };

        contestTypes = new List<string>
        {
            "BODYCOUNT",
            "AGE",
            "COUNTRIES VISITED",
            "HAD ONE NIGHT STANDS"
        };

        descriptionList = new List<string>
        {
            "To get friendzoned",
            "Is the biggest simp",
            "To have the worst cooking skills",
            "To have foot fetish",
            "Catch feelings after one night stand",
            "To never find true love",
            "To be the gayest",
            "To work at McDonalds",
            "To become a pornstar",
            "To have a child first",
            "You would fuck",
            "Biggest whore or fuckboy"
        };

        truth = new List<string>
        {
            "What is your worst date experiance",
            "Tell us about your ideal bodytype of  partner",
            "Tell us about your ideal character of your partner",
            "What is your biggest turn on",
            "Would you date me if we were single and correct gender"
        };
    }




}
