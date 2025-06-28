using System.Collections.Generic;
using UnityEngine;

public class GameEffects : MonoBehaviour
{
    public DrinkCounter drinkCounter;
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
    public List<string> dare;
    public List<string> roundStartDescription;
    public List<string> jackpot;
    public List<string> actionJackpot;



    public bool mustacheState;
    public bool bottomsUpState;
    public bool shotState;
    public bool slammerState;
    public bool kingsCupState;
    public bool competitiveState;
    public bool actionState;

    public int amount;
    public int previousAmount;
    public CanvasGroup disclaimerBackGround;
    public static bool shownDisclaimer = false;
    private bool hasActionBadBeenAdded = false;
    public int fontControlBig = 0;
    public int fontControlSmall = 0;


    private Dictionary<int, List<string>> usedEffectsDict = new Dictionary<int, List<string>>();
    void Update()
    {
        amount = drinkCounter.currentCounter;
        if (amount != previousAmount)
        {
            UpdateDynamicStrings();
            previousAmount = amount;
        }
    }
    public void YesReadRules()
    {
        disclaimerBackGround.alpha = 0f;
        disclaimerBackGround.interactable = false;
        disclaimerBackGround.blocksRaycasts = false;
    }


    public string GenerateRandomEffect(List<string> tableOfEffects)
    {
        const int maxAttempts = 100;
        int attempts = 0;
        if (tableOfEffects == null || tableOfEffects.Count == 0)
        {
            Debug.LogError("GenerateRandomEffect: Invalid input table");
            return "Error - invalid effect table";
        }

        int ableToRepeat = Mathf.Max(1, tableOfEffects.Count - 1);
        int tableKey = tableOfEffects.GetHashCode();

        if (!usedEffectsDict.ContainsKey(tableKey))
        {
            usedEffectsDict[tableKey] = new List<string>();
        }

        List<string> currentlyUsed = usedEffectsDict[tableKey];

        while (attempts < maxAttempts)
        {
            attempts++;
            string effect = tableOfEffects[Random.Range(0, tableOfEffects.Count)];

            if (!currentlyUsed.Contains(effect))
            {
                if (currentlyUsed.Count >= ableToRepeat)
                {
                    currentlyUsed.Clear();
                }

                currentlyUsed.Add(effect);
                return effect;
            }

            if (attempts >= maxAttempts - 5)
            {
                currentlyUsed.Clear();
            }
        }
        currentlyUsed.Clear();
        return tableOfEffects[Random.Range(0, tableOfEffects.Count)];

    }
    public void Awake()
    {
        if (!shownDisclaimer)
        {
            disclaimerBackGround.alpha = 1f;
            disclaimerBackGround.blocksRaycasts = true;
            disclaimerBackGround.interactable = true;
            shownDisclaimer = true;
        }
        else
        {
            disclaimerBackGround.alpha = 0f;
            disclaimerBackGround.blocksRaycasts = false;
            disclaimerBackGround.interactable = false;
        }

        amount = drinkCounter.currentCounter;
        previousAmount = drinkCounter.currentCounter - 1;

        UpdateDynamicStrings();

        comaLite = false;
        roundStart = false;

        if (Prefrences.Instance != null)
        {
            competitiveState = Prefrences.Instance.competitiveOn;
            actionState = Prefrences.Instance.actionOn;
        }

        typeOfEffectList = new List<string>
        {
            "TAKE",
            "TAKE",
            "TAKE",
            "TAKE",
            "TAKE",
            "GIVE",
            "GIVE",
            "GIVE",
            "GIVE",
            "GIVE",
            "EVERYONE",
            "EVERYONE ELSE",
            "SAME GENDER"
        };

        sideEffectList = new List<string>
        {
            "Have or been walked on during sex",
            "You are simp",
            "Virgin",
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
            "Under 180cm",
            "Over 180cm",
            "Had condom popped",
            "Used dating apps",
            "Currently using dating apps",
            "Been pregnancy scared",
            "Slept with older",
            "Have a child"
        };

        roundStartDescription = new List<string>
        {
            "If YOU have or been walked ON during sex",
            "If YOU are simp",
            "If YOU are virgin",
            "If YOU are sexy person",
            "If YOU are nice person",
            "If YOU hooked up with someone you met online",
            "If YOU are taken",
            "If YOU been with friends ex",
            "If YOU are attracted to present player",
            "If YOU have been skinny dipping",
            "If YOU have made selfie last week",
            "If YOU kissed or had sex with present player",
            "If YOU have been turned on by a fictional character",
            "If YOU ever lost keys or wallet",
            "If YOU are under 180cm",
            "If YOU are over 180cm",
            "If YOU ever had condom popped",
            "If YOU are currently using dating apps",
            "If YOU have been pregnancy scared",
            "If YOU have slept with older",
            "If YOU have a child",
            "For each relationhip",
            "For each VIRGINITY taken",
            "For each SIBLING",
            "For each BODYCOUNT",
            "For every virgin present"
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
            "What is your worst date experiance?",
            "Tell us about your ideal bodytype of a partner",
            "Tell us about your ideal character of a partner",
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
            "Would you say it's easy for you to be seduced? How? ",
            "What 'type' do you prefer to hook up with? ",
            "What's a fantasy of yours that has yet to happen?",
            "What about you do you think turns me on? ",
        };

        dare = new List<string>
        {
            "Go up to a stanger nearby and invite them to join our for a round of COMA",
            "Go up to a stanger nearby and ask for their phone number or social media",
            "Take a fun group photo of us playing COMA and post it to your story with #COMA"
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
            "FAMOUS MOVIE ACTRESS",
            "BEDROOM ITEM",
            };




    }
    public void UpdateDynamicStrings()
    {

        jackpot = new List<string>
        {
            "Everyone else "+ (5 + amount) +" penalties",
            "Everyone else "+ (5 + amount) +" penalties without using hands",
            "Everyone else STARE SLAVE to YOU and you take "+ (2 + amount) +" penalties"
        };

        actionJackpot = new List<string>
        {
            "DRAW Protection AND Treasure"
        };

        badEffects = new List<string>
        {
            "Draw 1 Round start",
            "Draw 2 Round starts",
            "TAKE "+ (3 + amount) +" penalties without using hands",
            "TAKE "+ (2 + amount) +" penalties without using hands",
            "TAKE penalties equal to your bodycount",
            "TAKE penalties equal to the continents you visited",
            "You are STARE SLAVE to your LEFT and they TAKE "+ (2 + amount) +" penalties",
            "You are STARE SLAVE to your LEFT and they TAKE "+ (3 + amount) +" penalties",
            "You are STARE SLAVE to your RIGHT and they TAKE "+ (2 + amount) +" penalties",
            "You are STARE SLAVE to your RIGHT and they TAKE "+ (3 + amount) +" penalties",
            "You and your RIGHT TAKE "+ (2 + amount) +" penalties",
            "You and your LEFT TAKE  "+ (3 + amount) +" penalties",
            "Increase your Penalty Counter by 1, TAKE "+ (1 + amount) +" penalties",
            "Increase your Penalty Counter by 1, TAKE "+ (2 + amount) +" penalties",
            "Increase your Penalty Counter by 1, TAKE "+ (3 + amount) +" penalties",
        };

        actionBad = new List<string>
        {
            "Draw 1 Round start. It becomes TAKE",
            "Draw 1 Round start. It becomes TAKE",
            "Draw 2 Round starts and they become TAKE",
            "Draw 2 Round starts and they become TAKE",
            "Draw CURSE",
            "Draw CURSE and TAKE "+ (1 + amount) +" penalties",
            "Draw CURSE and TAKE "+ (2 + amount) +" penalties",
            "Draw CURSE and TAKE "+ (3 + amount) +" penalties",
            "GIVE PROTECTION to your RIGHT",
            "GIVE PROTECTION to your RIGHT and you TAKE " + (1 + amount) +" penalties",
            "GIVE PROTECTION to your RIGHT and you TAKE "+ (2 + amount) +" penalties",
            "GIVE PROTECTION to your RIGHT and you TAKE "+ (3 + amount) +" penalties",
        };

        photographer = new List<string>
        {
            "TAKE photo with your RIGHT and random nearby object",
            "Everyone else takes photo of you",
            "TAKE photo with your RIGHT making intelectual faces",
            "TAKE a photo with your RIGHT and your LEFT making one you each sad, happy and confused faces",
            "TAKE a photo with your RIGHT hugging while both of you are fed "+ (2 + amount) +" penalties",
            "Everyone grabs an oject and balace it on their heads, TAKE selfie",
            "TAKE a group photo where everyone else puts their hands on your head"
        };

        goodEffects = new List<string>
        {
            "Draw 1 Round start",
            "Draw 2 Round starts",
            "GIVE "+ (2 + amount) +" penalties without using hands",
            "GIVE penalties equal to your bodycount",
            "GIVE penalties equal to the continents you visited",
            "GIVE STARE SLAVE to anyone on anyone and they TAKE "+ (2 + amount) +" penalties",
            "GIVE STARE SLAVE to anyone on anyone  and they TAKE "+ (3 + amount) +" penalties",
            "Your RIGHT is your STARE SLAVE  and they TAKE "+ (2 + amount) +" penalties",
            "Your RIGHT is your STARE SLAVE  and they TAKE "+ (3 + amount) +" penalties",
            "Everyone else "+ (2 + amount) +" penalties",
            "Your LEFT TAKE "+ (2 + amount) +" penalties",
            "Your RIGHT TAKE "+ (3 + amount) +" penalties",
            "Decrease your Penalty Counter by 1 and GIVE "+ (1 + amount) +" penalties",
            "Decrease your Penalty Counter by 1 and GIVE "+ (2 + amount) +" penalties",
            "Decrease your Penalty Counter by 1 and GIVE "+ (3 + amount) +" penalties"
        };

        actionGood = new List<string>
        {
            "Draw 1 Round start. It becomes GIVE",
            "Draw 1 Round start. It becomes GIVE",
            "Draw 2 Round starts and they become GIVE",
            "Draw 2 Round starts and they become GIVE",
            "Draw PROTECTION",
            "Draw PROTECTION and GIVE "+ (1 + amount) +" penalties",
            "Draw PROTECTION and GIVE "+ (2 + amount) +" penalties",
            "Draw PROTECTION and GIVE "+ (3 + amount) +" penalties",
            "Draw TREASURE",
            "Draw TREASURE and TAKE "+ (1 + amount) +" penalties",
            "Draw TREASURE and GIVE "+ (1 + amount) +" penalties"
        };

        if (actionState && !hasActionBadBeenAdded)
    {
        badEffects.AddRange(actionBad);
        goodEffects.AddRange(actionBad); 
        jackpot.AddRange(actionJackpot); 
        hasActionBadBeenAdded = true; 
    }
    }
}

