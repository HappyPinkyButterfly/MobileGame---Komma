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

    public List<string> faceOffWho;

    public List<string> detective;

    public List<string> photographer;

    public List<string> actionBad;

    public List<string> actionGood;
    public List<string> typeOfEffectList;
    public List<string> typeOfDrinkingList;
    public List<string> sideEffectList;

    

    public bool mustacheState;
    public bool bottomsUpState;
    public bool shotState;
    public bool slammerState;
    public bool kingsCupState;
    public bool competitiveState;
    public bool actionState;
    
    public  List<string> usedEffects;
    


    public string GenerateRandomEffect(List<string> tableOfEffects)
    {
        int ableToRepeat = 10;
        if (tableOfEffects.Count <= 10 || tableOfEffects.Count == 0)
        {
            return "Error has occured, contanct SupremeLab Productions";
        }

        while (true)
        {
            string effect = tableOfEffects[Random.Range(0, badEffects.Count)];
            if (!usedEffects.Contains(effect) && usedEffects.Count != ableToRepeat)
            {
                usedEffects.Add(effect);
                return effect;
            }
            else if (!usedEffects.Contains(effect) && usedEffects.Count == ableToRepeat)
            {
                usedEffects.Add(effect);
                usedEffects.RemoveAt(0);
                return effect;
            }
        }
    }
    public void Awake()
    {
        comaLite = false;
        roundStart = false;

        if (Prefrences.Instance != null)
        {
            mustacheState = Prefrences.Instance.mustacheOn;
            bottomsUpState = Prefrences.Instance.bottomsUpOn;
            shotState = Prefrences.Instance.shotOn;
            slammerState = Prefrences.Instance.slammerOn;
            kingsCupState = Prefrences.Instance.kingsCupOn;
            competitiveState = Prefrences.Instance.competitiveOn;
            actionState = Prefrences.Instance.actionOn;
        }



        typeOfEffectList = new List<string>
        {
            "TAKE",
            "TAKE",
            "TAKE",
            "GIVE",
            "GIVE",
            "GIVE",
            "TAKE AND GIVE",
            "EVERYONE",
            "EVERYONE ELSE",
            "SAME GENDER"
        };

        typeOfDrinkingList = new List<string>
        {
            "Sips",
            "Sips",
            "Sips",
            "Second Chug"
        };

        sideEffectList = new List<string>
        {
            "Have or been walked on during sex",
            "You are simp",
            "For each bodycount",
            "Virgin",
            "Drinking vodka",
            "Not drinking vodka",
            "Sexy person",
            "Nice person",
            "Hooked up with someone you met online",
            "Taken",
            "Been with friends ex",
            "Attracted to present player",
            "Been skinny dipping",
            "Have made selfie last week",
            "Kissed or had sex with present player",
            "Turned on by a fictional character",
            "Ever lost keys or wallet",
            "Ever puked first",
            "For every virgin present",
            "Under 180cm",
            "Over 180cm",
            "For each relationhip",
            "Ever had body shot",
            "Had condom popped",
            "For each sibling",
            "Used dating apps",
            "Currently using dating apps",
            "For each virginity taken",
            "Been pregnancy scared",
            "Slept with older",
            "Have a child"
        };

        badEffects = new List<string>
        {

            "Draw 1 Round start. It becomes TAKE and + 1",
            "Draw 1 Round start. It becomes TAKE and + 1",
            "Draw 2 Round starts and they become TAKE",
            "Draw 2 Round starts and they become TAKE",
            "Take 3 Sips",
            "Chug 3 Seconds",
            "Take sips equal to your bodycount",
            "Take sips equal to the continents you visited",
            "You are STARE SLAVE to your LEFT and they take 2 sips",
            "You are STARE SLAVE to your LEFT and they take 3 sips",
            "You are STARE SLAVE to your RIGHT and they take 3 sips",
            "You are STARE SLAVE to your RIGHT and they take 2 sips",
            "Take 3 sips, you cannot touch your drink",
            "Take chug 2 seconds, you cannot touch your drink",
            "You and your RIGHT take 3 sips",
            "You and your LEFT take chug 3 seconds",
            "All sips and Chugs YOU take are +1, take 1 sip",
            "All sips and Chugs YOU take are +1, take 1 sip",
            "All sips and Chugs YOU take are +1, take 1 sip",
            "All sips and Chugs YOU take are +1, take 1 sip",
            "Everyones sips and chugs they take are + 1"

        };

        actionBad = new List<string>
        {
            "DRAW Curse and TAKE 2 sips",
            "DRAW Curse and TAKE 1 sip",
            "DRAW Curse and TAKE 2 sips",
            "DRAW Curse and TAKE 1 sip",
            "Give Protection to your RIGHT and TAKE 1 sip",
            "Give Protection to your RIGHT and TAKE 2 sips"
        };



        goodEffects = new List<string>
        {
            "Draw 1 Round start. It becomes GIVE and +1",
            "Draw 1 Round start. It becomes GIVE and +1",
            "Draw 2 Round starts and they become GIVE",
            "Give 4 Sips",
            "Give chug 3 Seconds",
            "Give sips equal to your bodycount",
            "Give sips equal to the continents you visited",
            "Give STARE SLAVE to your LEFT on you and they take 2 sips",
            "Give STARE SLAVE to your LEFT on you and they take 2 sips",
            "Give STARE SLAVE to your RIGHT on you and they take 3 sips",
            "Give STARE SLAVE to your RIGHT on you and they take 3 sips",
            "Everyone else 2 sips",
            "Everyone else chug 2 Seconds",
            "Your LEFT take 3 sips",
            "Your RIGHT take chug 3 seconds",
            "Give 'All sips and Chugs YOU take are +1, take 1 sip'",
            "Give 'All sips and Chugs YOU take are +1, take 1 sip'",
            "Give 'All sips and Chugs YOU take are +1, take 1 sip'",
            "Everyones sips and chugs they take are - 1",

        };

        actionGood = new List<string>
        {
            "DRAW Protection",
            "DRAW Protection",
            "DRAW Protection",
            "DRAW Protection",
            "DRAW Treasure"
        };

        if (actionState)
        {
            badEffects.AddRange(actionBad);
            goodEffects.AddRange(actionGood);
        }

        faceOffWho = new List<string>
        {
            "with the person with closest to your",
            "with the person with furthest to your",
            "with the person with closest to your",
            "with the person with furthest to your",
            "with the person with closest to your",
            "with the person with furthest to your",
            "with the person with closest to your",
            "with the person with furthest to your",
            "with the person with closest to your",
            "with the person with furthest to your",
            "with the person with closest to your",
            "with the person with furthest to your"
        };

        contestTypes = new List<string>
        {
            "BODYCOUNT",
            "AGE",
            "COUNTRIES VISITED",
            "HAD ONE NIGHT STANDS",
            "INSTAGRAM FOLLOWERS",
            "YEARS SINGLE/TAKEN CURRENTLY",
            "NUMBER OF TATTOOS",
            "LENGTH OF LONGEST RELATIONSHIP",
            "TIMES GOT REJECTED",
            "NUMBER OF DRINKS HAD TONIGHT",
            "NUMBER OF LANGUAGES SPOKEN",
            "NUMBER OF DIFFERENT JOBS HAD",
            "NUMBER OF INSTRUMENTS PLAYED",
            "MOST EXPENSIVE PURCHASE"
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
            "Regularly check an exs Instagram",
            "Date their best friends ex",
            "Wear socks with sandals",
            "Give the best hug",
            "have the highest screen time",
            "Become an influencer",
            "Laugh in a serious moment",
            "Commit a crime",
            "Have a threesome",
            "Marry for money"
        };

        truth = new List<string>
        {
            "What is your worst date experiance",
            "Tell us about your ideal bodytype of  partner",
            "Tell us about your ideal character of your partner",
            "What is your biggest turn on",
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
            "Would you accept an arranged marriage? Why? ",
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
            "BE DOMINANT IN BED:",
            "HAVE AMAZING CONVERSATION:",
            "HAVE TOES SUCKED",
            "SHOW PORN HISTORY TO PARTNER",
            "BE BLINDFOLDED",
            "ONLY HAVE 'VANILLA' SEX",
            "PEG SOMEONE",
            "WATCH STRANGERS HAVE SEX",
            "HAVE SEX WHILE BLINDFOLDED",
            "SNEEZE EVERY TIME YOU ORGASM",
            "NEVER HAVE SEX AGAIN",
            "EAT ICE CREAM WITH KETCHUP",
            "HAVE TEETH FOR HAIR",
            "HAVE DRUNK SEX"
        };

        wouldYouRather2 = new List<string>
        {
            "BE SUBMISIVE IN BED:",
            "HAVE AN AMAZING SEX:",
            "SUCK TOES",
            "TO BEST FRIEND",
            "BE GAGGED",
            "ONLY HAVE 'BDSM' SEX",
            "BE PEGGED",
            "HAVE STRANGERS WATCH YOU HAVE SEX",
            "HAVE SEX WHILE HANDCUFFED",
            "FART EVERY TIME YOU ORGASM",
            "NEVER EAT YOUR FAVORITE FOOD AGAIN",
            "EAT BANANA WITH KETCHUP",
            "HAIR FOR TEETH",
            "HAVE HIGH SEX"
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

        detective = new List<string>
        {
            "MY BEST TRAIT",
            "FAMOUS MOVIE ACTOR",
            "KITCHEN ITEM",
            "COUNTRY IN EUROPE",
            "EVERYDAY JOB",
            "HISTORICAL FIGURE",
            "CLASSROOM ITEM",
            "MY BEST TRAIT",
            "FAMOUS MOVIE ACTOR",
            "KITCHEN ITEM",
            "COUNTRY IN EUROPE",
            "EVERYDAY JOB",
            "HISTORICAL FIGURE",
            "CLASSROOM ITEM",
            };

        photographer = new List<string>
        {
            "Take photo with your RIGHT and random nearby object, they take 3 sips",
            "Everyone takes a photo of their drink like it's a luxury product ad, group votes best one, others 2 sips drink",
            "Everyone else takes photo of you, everyone else but the best one take 3 sips",
            "Take photo with <-- making intelectual faces and both take 2 sips",
            "Take group photo with all your drinks",
            "Take a video of everyone else chuging 3 seconds",
            "Take a photo with your RIGHT and your LEFT making one you each sad, happy and confused faces, they drink 2 sips",
            "Take a photo with your RIGHT hugging and both of you are fed 2 sips",
            "Everyone grabs an oject and balace it on their heads, take selfie",
            "Take a video of someone swiping on dating app, if no present player has one, you take 2 sips",
            "Make a group photo where everyone else puts their hands on your head"
        };

        int repetitionsGood = goodEffects.Count / 10;

        for (int i = 0; i < repetitionsGood; i++)
        {
            if (mustacheState)
            {
                goodEffects.Add("Give Mustache");
                goodEffects.Add("Give Mustache");
                goodEffects.Add("Give Mustache");
                goodEffects.Add("Give Mustache");
            }
            if (shotState)
            {
                goodEffects.Add("Give SHOT");
                goodEffects.Add("Give SHOT");
                goodEffects.Add("Give SHOT");
            }
            if (bottomsUpState)
            {
                goodEffects.Add("Give BottomsUp");
                goodEffects.Add("Give BottomsUp");
                goodEffects.Add("Give BottomsUp");
            }
            if (slammerState)
            {
                goodEffects.Add("Give Slammer");
                goodEffects.Add("Give Slammer");
                goodEffects.Add("Give Slammer");
            }
            if (kingsCupState)
            {
                goodEffects.Add("Give Kings Cup");
                goodEffects.Add("Give Kings Cup");
                goodEffects.Add("Give Kings Cup");
                goodEffects.Add("Give Kings Cup");
            }
        }

        int repetitionsBad = badEffects.Count / 10;

        for (int i = 0; i < repetitionsBad; i++)
        {
            if (mustacheState)
            {
                badEffects.Add("Take Mustache");
                badEffects.Add("Take Mustache");
                badEffects.Add("Take Mustache");
                badEffects.Add("Take Mustache");
            }
            if (shotState)
            {
                badEffects.Add("Take SHOT");
                badEffects.Add("Take SHOT");
                badEffects.Add("Take SHOT");
            }
            if (bottomsUpState)
            {
                badEffects.Add("Take BottomsUp");
                badEffects.Add("Take BottomsUp");
                badEffects.Add("Take BottomsUp");
            }
            if (slammerState)
            {
                badEffects.Add("Take Slammer");
                badEffects.Add("Take Slammer");
                badEffects.Add("Take Slammer");
            }
            if (kingsCupState)
            {
                badEffects.Add("Take Kings Cup");
                badEffects.Add("Take Kings Cup");
                badEffects.Add("Take Kings Cup");
                badEffects.Add("Take Kings Cup");
            }
        }
    }
}
