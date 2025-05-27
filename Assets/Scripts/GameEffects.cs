using System;
using System.Collections.Generic;
using UnityEngine;

public class GameEffects : MonoBehaviour
{
    public bool comaLite;
    public bool roundStart;
    public List<string> badEffects;
    public List<string> goodEffects;
    public List<string> contestTypes;
    public List<string> descriptionList;
    public List<string> truth;

    public List<string> wouldYouRather1;
    public List<string> wouldYouRather2;
    public List<string> neverHaveIever;

    private bool mustacheState;
    private bool bottomsUpState;
    private bool shotState;


    public void Awake()
    {
        if (Prefrences.Instance != null)
        {
            mustacheState = Prefrences.Instance.mustacheOn;
            bottomsUpState = Prefrences.Instance.bottomsUpOn;
            shotState = Prefrences.Instance.shotOn;
        }

        comaLite = false;
        roundStart = false;

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
            "Opposite genders take a photo with you and give 5 sips",
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
            "Biggest whore or fuckboy",
            "Marry someone rich and famous",
            "Date more than one person at a time",
            "Get arrested",
            "Die first in a horror film",
            "Regularly check an ex’s Instagram",
            "Date their best friend’s ex",
            "Wear socks with sandals",
            "Give the best hug",
            "have the highest screen time",
            "Become an influencer",
            "Laugh in a serious moment",
            "Commit a crime?",
            "Have a threesome?",
            "Marry for money?"
        };

        truth = new List<string>
        {
            "What is your worst date experiance",
            "Tell us about your ideal bodytype of  partner",
            "Tell us about your ideal character of your partner",
            "What is your biggest turn on",
            "Would you date me if we were single and correct gender",
            "Describe your worst injury",
            "What's a mistake you've made that you still feel guilty about",
            "What's something you've Googled that you aren't proud to admit",
            "How do you really feel about your job?",
            "Who in the group has the most attractive parents?",
            "What's your dream job? ",
            "Have you ever done something so wrong that you immediately regretted it? What? ",
            "How do you handle rejection? ",
            "What do you consider to be the most romantic thing a person could do?",
            "How do you define love? ",
            "What habits attract you the most? ",
            "Would you accept an arranged marriage? ",
            "What's your craziest one-night stand story?",
            "What's the most embarrassing experience you've had while in bed?",
            "What's your favorite position in bed? ",
            "Would you say it's easy for you to be seduced? ",
            "What 'type' do you prefer to hook up with? ",
            "What's a fantasy of yours that has yet to happen?",
            "What about you do you think turns me on? ",
        };

        wouldYouRather1 = new List<string>
        {
            "Be dominat in bed:",
            "Have amazing conversation:",
            "Have toes sucked",
            "Show porn history to partner",
            "Be blindfolded",
            "Only have 'vanilla' sex",
            "Peg someone",
            "Watch strangers have sex",
            "Have sex while blindfolded",
            "Sneeze every time you orgasm",
            "Never have sex again",
            "Eat ice cream with ketchup",
            "Have teeth for hair",
            "Have drunk sex"

        };

        wouldYouRather2 = new List<string>
        {
            "Be submisive in bed:",
            "Have an amazing sex:",
            "Suck toes",
            "To best friend",
            "Be gagged",
            "Only have 'BDSM' sex",
            "Be pegged",
            "Have strangers watch you have sex",
            "Have sex while handcuffed",
            "Fart every time you orgasm",
            "Never eat your favorite food again",
            "Eat banana with ketchup",
            "Hair for teeth",
            "Have high sex"

        };

        neverHaveIever = new List<string>
        {
            "Stolen anything",
            "Missed a flight",
            "Drunk-dialed my ex",
            "Gone skinny-dipping",
            "Been on a yacht",
            "Been on TV",
            "Had to go to court",
            "Kissed more than one person in 24 hours",
            "Had a one-night stand",
            "Gone on a solo vacation",
            "Gotten stopped by airport security",
            "Had a threesome",
            "Lied about my age",
            "Been the alibi for a lying friend",
            "Role-played",
            "Worn someone elses underwear",
            "Gone to a strip club",
            "Tried psychedelics",
            "Met someone famous",
            "Had sex on a beach",
            "Dated someone older than me",
            "Dated someone younger than me",
            "Had a friend with benefits",
            "Kissed a friend"
        };

        if (mustacheState)
        {
            int targetSpawn = 10;

            for (int i = 0; i < goodEffects.Count; i++)
            {
                if (i == targetSpawn)
                {
                    goodEffects.Add("Give Mustache");
                    goodEffects.Add("Give Mustache 2x");
                }
            }

            for (int i = 0; i < badEffects.Count; i++)
            {
                if (i == targetSpawn)
                {
                    badEffects.Add("Take Mustache");
                    badEffects.Add("Take Mustache 2x");
                }
            }


            if (shotState)
            {
                for (int i = 0; i < goodEffects.Count; i++)
                {
                    if (i == targetSpawn)
                    {
                        goodEffects.Add("Give SHOT");
                        goodEffects.Add("Give SHOT");
                    }
                }

                for (int i = 0; i < badEffects.Count; i++)
                {
                    if (i == targetSpawn)
                    {
                        badEffects.Add("Take SHOT");
                        badEffects.Add("Take SHOT");
                    }
                }
            }

            if (bottomsUpState)
            {
                for (int i = 0; i < goodEffects.Count; i++)
                {
                    if (i == targetSpawn)
                    {
                        goodEffects.Add("Give BottomsUp");
                        goodEffects.Add("Give BottomsUp");
                    }
                }

                for (int i = 0; i < badEffects.Count; i++)
                {
                    if (i == 10)
                    {
                        badEffects.Add("Take BottomsUp");
                        badEffects.Add("Take BottomsUp");
                    }
                }
            }
        }
    }
}
