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
    public int fontControlBig = -3;
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
            "EVERYONE",
            "EVERYONE ELSE",
            "SAME GENDER"
        };

        sideEffectList = new List<string>
        {
            "Attracted to present player",
            "Been pregnancy scared",
            "Been skinny dipping",
            "Been with friends ex",
            "Have a child",
            "Have made selfie last week",
            "Have or been walked on during sex",
            "Had condom popped",
            "Hooked up with someone you met online",
            "Kissed or had sex with present player",
            "Nice person",
            "Over 180cm",
            "Sexy person",
            "Slept with older",
            "Taken",
            "Turned on by a fictional character",
            "Under 180cm",
            "Used dating apps",
            "Currently using dating apps",
            "Ever lost keys or wallet",
            "Virgin",
            "You are simp"
        };

        roundStartDescription = new List<string>
        {
            "For each BODYCOUNT",
            "For each RELATIONSHIP",
            "For each SIBLING",
            "For each VIRGINITY taken",
            "For every virgin present",
            "If YOU are a nice person",
            "If YOU are a sexy person",
            "If YOU are attracted to the present player",
            "If YOU are over 180cm",
            "If YOU are taken",
            "If YOU are under 180cm",
            "If YOU are virgin",
            "If YOU are simp",
            "If YOU ever had a condom pop",
            "If YOU ever lost keys or wallet",
            "If YOU have a child",
            "If YOU have been pregnancy scared",
            "If YOU have been skinny dipping",
            "If YOU have been turned on by a fictional character",
            "If YOU have hooked up with someone you met online",
            "If YOU have made a selfie last week",
            "If YOU have or have been walked on during sex",
            "If YOU have slept with someone older",
            "If YOU kissed or had sex with the present player",
            "If YOU have been with a friend's ex"
        };

        contestTypes = new List<string>
        {
            "AGE",
            "BODYCOUNT",
            "HAD ONE-NIGHT STANDS",
            "INSTAGRAM FOLLOWERS",
            "LENGTH OF LONGEST RELATIONSHIP",
            "MOST EXPENSIVE PURCHASE",
            "NUMBER OF TATTOOS",
            "YEARS SINGLE/TAKEN CURRENTLY"
        };

        descriptionList = new List<string>
        {
            "Become an influencer",
            "Be the gayest",
            "Biggest whore or fuckboy",
            "Catch feelings after a one-night stand",
            "Commit a crime",
            "Date more than one person at a time",
            "Date their best friend's ex",
            "Die first in a horror film",
            "Get arrested",
            "Get friendzoned",
            "Give the best hug",
            "Have a threesome",
            "Have the highest screen time",
            "Have a foot fetish",
            "Have a child first",
            "Is the biggest simp",
            "Laugh in a serious moment",
            "Marry for money",
            "Marry someone rich and famous",
            "Regularly check an ex's Instagram",
            "Have the worst cooking skills",
            "Never find true love",
            "Work at McDonald's",
            "Become a pornstar",
            "Wear socks with sandals",
            "You would fuck"
        };

        truth = new List<string>
        {
            "Have you ever done something so wrong that you immediately regretted it? What?",
            "How do you define love?",
            "How do you handle rejection?",
            "Tell us about your ideal body type of a partner",
            "Tell us about your ideal character of a partner",
            "What about you do you think turns me on?",
            "What habits attract you the most?",
            "What is your biggest turn-on?",
            "What is your worst date experience?",
            "What's a mistake you've made that you still feel guilty about?",
            "What's something you've Googled that you aren't proud to admit?",
            "What's your craziest one-night stand story?",
            "What's the most embarrassing experience you've had while in bed?",
            "What's your favorite position in bed?",
            "Would you say it's easy for you to be seduced? How?"
        };

        dare = new List<string>
        {
            "Go up to a stranger nearby and ask for their phone number or social media",
            "Go up to a stranger nearby and invite them to join us for a round of KOMMA",
            "Take a fun group photo of us playing KOMMA and post it to your story with #KOMMA"
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
            "Been on a yacht",
            "Been on TV",
            "Been the alibi for a lying friend",
            "Dated someone older than me",
            "Dated someone younger than me",
            "Drunk-dialed my ex",
            "Gone on a solo vacation",
            "Gone skinny-dipping",
            "Gone to a strip club",
            "Gotten stopped by airport security",
            "Had a friend with benefits",
            "Had a one-night stand",
            "Had a threesome",
            "Had sex on a beach",
            "Had to go to court",
            "Kissed a friend",
            "Kissed more than one person in 24 hours",
            "Lied about my age",
            "Met someone famous",
            "Missed a flight",
            "Role-played",
            "Stolen anything",
            "Tried psychedelics",
            "Worn someone else's underwear"
        };

        detective = new List<string>
        {
            "BEDROOM ITEM",
            "CLASSROOM ITEM",
            "COUNTRY IN EUROPE",
            "EVERYDAY JOB",
            "FAMOUS MOVIE ACTOR",
            "FAMOUS MOVIE ACTRESS",
            "HISTORICAL FIGURE",
            "KITCHEN ITEM",
            "MY BEST TRAIT"
        };
    }
    public void UpdateDynamicStrings()
    {

        jackpot = new List<string>
        {
            "Everyone else TAKE " + (6 + amount) + " penalties without using hands",
            "Everyone else TAKE " + (7 + amount) + " penalties",
            "Everyone else is STARE SLAVE to YOU, TAKE " + (2 + amount) + " penalties"
        };

        actionJackpot = new List<string>
        {
            "DRAW Protection AND Treasure"
        };

        badEffects = new List<string>
        {
            "Draw 1 Round start",
            "Draw 2 Round starts",
            "TAKE " + (3 + amount) + " penalties without using hands",
            "TAKE " + (2 + amount) + " penalties without using hands",
            "TAKE penalties equal to your body count",
            "You are STARE SLAVE to your LEFT, and they TAKE " + (2 + amount) + " penalties",
            "You are STARE SLAVE to your RIGHT, and they TAKE " + (3 + amount) + " penalties",
            "You and your LEFT TAKE " + (3 + amount) + " penalties",
            "You and your RIGHT TAKE " + (2 + amount) + " penalties",
            "Increase your Penalty Counter by 1, then TAKE " + (2 + amount) + " penalties",
            "Increase your Penalty Counter by 1, then TAKE " + (3 + amount) + " penalties"
        };

        actionBad = new List<string>
        {
            "Draw 1 Round start; it becomes TAKE",
            "Draw 2 Round starts; they become TAKE",
            "Draw CURSE",
            "Draw CURSE and TAKE " + (1 + amount) + " penalty",
            "Draw CURSE and TAKE " + (2 + amount) + " penalties",
            "GIVE PROTECTION to your RIGHT",
            "GIVE PROTECTION to your RIGHT and TAKE " + (1 + amount) + " penalty",
            "GIVE PROTECTION to your RIGHT and TAKE " + (2 + amount) + " penalties"
        };

        photographer = new List<string>
        {
            "TAKE a photo with your RIGHT and a random nearby object",
            "TAKE a photo with your RIGHT making intellectual faces",
            "TAKE a photo with your RIGHT and your LEFT making sad, happy, and confused faces (one each)",
            "TAKE a photo with your RIGHT hugging while both of you are fed " + (2 + amount) + " penalties",
            "TAKE a group photo where everyone else puts their hands on your head",
            "Everyone else takes a photo of you",
            "Everyone grabs an object and balances it on their heads; TAKE a selfie"
        };

        goodEffects = new List<string>
        {
            "Decrease your Penalty Counter by 1 and GIVE " + (1 + amount) + " penalty",
            "GIVE " + (2 + amount) + " penalties without using hands",
            "GIVE penalties equal to your body count",
            "GIVE STARE SLAVE to anyone, and they TAKE " + (2 + amount) + " penalties",
            "Your LEFT TAKE " + (2 + amount) + " penalties",
            "Your RIGHT is your STARE SLAVE and they TAKE " + (2 + amount) + " penalties",
            "Your RIGHT TAKE " + (3 + amount) + " penalties",
            "Everyone else TAKE " + (2 + amount) + " penalties"
        };

        actionGood = new List<string>
        {
            "Draw 1 Round start; it becomes GIVE",
            "Draw 2 Round starts; they become GIVE",
            "Draw PROTECTION",
            "Draw PROTECTION and GIVE " + (2 + amount) + " penalties",
            "Draw PROTECTION and GIVE " + (3 + amount) + " penalties",
            "Draw TREASURE",
            "Draw TREASURE and TAKE " + (1 + amount) + " penalty",
            "Draw TREASURE and GIVE " + (1 + amount) + " penalty"
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

