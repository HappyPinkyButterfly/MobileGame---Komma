using System.Collections.Generic;
using System.Linq.Expressions;
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



    public bool mustacheState;
    public bool bottomsUpState;
    public bool shotState;
    public bool slammerState;
    public bool kingsCupState;
    public bool competitiveState;
    public bool actionState;

    public int amount;
    public int previousAmount;

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


    public string GenerateRandomEffect(List<string> tableOfEffects)
    {
        int ableToRepeat = tableOfEffects.Count - 1;
        if (tableOfEffects.Count <= ableToRepeat || tableOfEffects.Count == 0 || tableOfEffects == null)
        {
            return "Error has occured, contanct SupremeLab Productions";
        }

        int tableKey = tableOfEffects.GetHashCode();

        if (!usedEffectsDict.ContainsKey(tableKey))
        {
            usedEffectsDict[tableKey] = new List<string>();
        }

        List<string> currentlyUsed = usedEffectsDict[tableKey];

        while (true)
        {
            string effect = tableOfEffects[Random.Range(0, tableOfEffects.Count)];


            if (!currentlyUsed.Contains(effect) && currentlyUsed.Count != ableToRepeat)
            {
                currentlyUsed.Add(effect);
                usedEffectsDict[tableKey] = currentlyUsed;
                

            string dictContents = "Dictionary contents:\n";
            foreach (var kvp in usedEffectsDict)
            {
                dictContents += $"Key: {kvp.Key}, Values: {string.Join(", ", kvp.Value)}\n";
            }
            Debug.Log(dictContents);



                return effect;
            }
            else if (!currentlyUsed.Contains(effect) && currentlyUsed.Count == ableToRepeat)
            {
                currentlyUsed.Clear();
                currentlyUsed.Add(effect);
                usedEffectsDict[tableKey] = currentlyUsed;
                
                
                string dictContents = "Dictionary contents:\n";
                foreach (var kvp in usedEffectsDict)
                {
                    dictContents += $"Key: {kvp.Key}, Values: {string.Join(", ", kvp.Value)}\n";
                }
                Debug.Log(dictContents);


                return effect;
            }
        }
        
    }
    public void Awake()
    {
        

        amount = drinkCounter.currentCounter;
        previousAmount = drinkCounter.currentCounter - 1;

        UpdateDynamicStrings();

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
            "TAKE",
            "GIVE",
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
            "Go up to a stanger nearby and invite them to join our for a round of the drinking game COMA",
            "Go up to a stanger nearby and ask for their phone number or social media",
            "Take a fun group photo of us playing COMA and post it to your story with #DrinkingGameCOMA"
            //"Go up to a stranger and ask them for a selfie (Optional: everyone else picks your target)"
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
        badEffects = new List<string>
        {
            "Draw 1 Round start. It becomes TAKE.",
            "Draw 1 Round start. It becomes TAKE and + 1",
            "Draw 2 Round starts and they become TAKE",
            "Draw 2 Round starts and they become TAKE - 1",
            "TAKE "+ (3 + amount) +" sips",
            "Chug "+ (3 + amount) +" Seconds",
            "TAKE sips equal to your bodycount",
            "TAKE sips equal to the continents you visited",
            "You are STARE SLAVE to your LEFT and they TAKE "+ (2 + amount) +" sips",
            "You are STARE SLAVE to your LEFT and they TAKE "+ (3 + amount) +" sips",
            "You are STARE SLAVE to your RIGHT and they TAKE "+ (2 + amount) +" sips",
            "You are STARE SLAVE to your RIGHT and they TAKE "+ (3 + amount) +" sips",
            "TAKE "+ (3 + amount) +" sips, you cannot touch your drink",
            "TAKE chug "+ (2 + amount) +" seconds, you cannot touch your drink",
            "You and your RIGHT TAKE "+ (2 + amount) +" sips",
            "You and your LEFT TAKE chug "+ (3 + amount) +" seconds",
            "Increase your SipChug Counter by 1",
            "Increase your SipChug Counter by 1, TAKE "+ (1 + amount) +" sip",
            "Increase your SipChug Counter by 1, TAKE "+ (2 + amount) +" sip",
            "Increase your SipChug Counter by 1, TAKE "+ (2 + amount) +" sips",
            "Everyones Increases their SipChug Counter by 1"
        };

        actionBad = new List<string>
        {   "Draw CURSE and TAKE "+ (1 + amount) +" sip",
            "Draw CURSE and TAKE "+ (1 + amount) +" sip",
            "Draw CURSE and TAKE "+ (2 + amount) +" sips",
            "Draw CURSE and TAKE "+ (3 + amount) +" sips",
            "GIVE PROTECTION to your RIGHT and they TAKE "+ (1 + amount) +" sip",
            "GEIVE PROTECTION to your RIGHT and they TAKE "+ (2 + amount) +" sips",
            "GIVE PROTECTION to your RIGHT and they TAKE "+ (3 + amount) +" sip",
        };

        photographer = new List<string>
        {
            "TAKE photo with your RIGHT and random nearby object, they TAKE "+ (2 + amount) +" sips",
            "Everyone takes a photo of their drink like it's a luxury product ad, group votes best one, others TAKE "+ (2 + amount) +" sips",
            "Everyone else takes photo of you, everyone else but the best one TAKE "+ (2 + amount) +" sips",
            "TAKE photo with your RIGHT making intelectual faces and both TAKE "+ (2 + amount) +" sips",
            "TAKE group photo with all your drinks",
            "TAKE a video of everyone else chuging "+ (2 + amount) +" seconds",
            "TAKE a photo with your RIGHT and your LEFT making one you each sad, happy and confused faces, they TAKE "+ (2 + amount) +" sips",
            "TAKE a photo with your RIGHT hugging and both of you are fed "+ (2 + amount) +" sips",
            "Everyone grabs an oject and balace it on their heads, TAKE selfie",
            "TAKE a video of someone swiping on dating app, if no present player has one, you TAKE "+ (2 + amount) +" sips",
            "TAKE a group photo where everyone else puts their hands on your head"
        };

        goodEffects = new List<string>
        {
            "Draw 1 Round start. It becomes GIVE",
            "Draw 1 Round start. It becomes GIVE and + 1",
            "Draw 2 Round starts and they become GIVE",
            "Draw 2 Round starts and they become GIVE - 1",
            "GIVE "+ (2 + amount) +" Sips",
            "GIVE chug "+ (2 + amount) +" Seconds",
            "GIVE sips equal to your bodycount",
            "GIVE sips equal to the continents you visited",
            "GIVE STARE SLAVE to anyone on anyone and they TAKE "+ (2 + amount) +" sips",
            "GIVE STARE SLAVE to anyone on anyone  and they TAKE "+ (3 + amount) +" sips",
            "Your RIGHT is your STARE SLAVE  and they TAKE "+ (2 + amount) +" sips",
            "Your RIGHT is your STARE SLAVE  and they TAKE "+ (3 + amount) +" sips",
            "Everyone else "+ (2 + amount) +" sips",
            "Everyone else chug "+ (2 + amount) +" seconds",
            "Your LEFT TAKE "+ (2 + amount) +" sips",
            "Your RIGHT TAKE "+ (3 + amount) +" sips",
            "Your LEFT TAKE chug "+ (2 + amount) +" seconds",
            "Your RIGHT TAKE chug "+ (3 + amount) +" seconds",
            "GIVE 'Increase your SipChug Counter by 1, TAKE "+ (1 + amount) +" sip'",
            "GIVE 'Increase your SipChug Counter by 1, TAKE "+ (2 + amount) +" sip'",
            "GIVE 'Increase your SipChug Counter by 1, TAKE "+ (3 + amount) +" sip'",
            "Decrease your SipChug Countey by 1 and GIVE "+ (1 + amount) +" sip",
            "Decrease your SipChug Countey by 1 and GIVE "+ (2 + amount) +" sip",
            "Everyones Decreases their SipChug Counter by 1"
        };

        actionGood = new List<string>
        {
            "Draw PROTECTION",
            "Draw PROTECTION",
            "Draw PROTECTION and GIVE "+ (1 + amount) +" sip",
            "Draw PROTECTION and GIVE "+ (2 + amount) +" sips",
            "Draw PROTECTION and GIVE "+ (3 + amount) +" sips",
            "Draw TREASURE",
            "Draw TREASURE"
        };

        if (actionState)
        {
            badEffects.AddRange(actionBad);
            goodEffects.AddRange(actionGood);
        }

        int repetitionsGood = goodEffects.Count / 10;

        for (int i = 0; i < repetitionsGood; i++)
        {
            if (mustacheState)
            {
                goodEffects.Add("GIVE Mustache");
                goodEffects.Add("GIVE Mustache");
                goodEffects.Add("GIVE Mustaches");
                goodEffects.Add("GIVE Mustache");
            }
            if (shotState)
            {
                goodEffects.Add("GIVE Shot");
                goodEffects.Add("GIVE Shot");
                goodEffects.Add("GIVE Shot");
            }
            if (bottomsUpState)
            {
                goodEffects.Add("GIVE BottomsUp");
                goodEffects.Add("GIVE BottomsUp");
                goodEffects.Add("GIVE BottomsUp");
            }
            if (slammerState)
            {
                goodEffects.Add("GIVE Slammer");
                goodEffects.Add("GIVE Slammer");
                goodEffects.Add("GIVE Slammer");
            }
            if (kingsCupState)
            {
                goodEffects.Add("GIVE Kings Cup");
                goodEffects.Add("GIVE Kings Cup");
                goodEffects.Add("GIVE Kings Cup");
                goodEffects.Add("GIVE Kings Cup");
            }
        }

        int repetitionsBad = badEffects.Count / 10;

        for (int i = 0; i < repetitionsBad; i++)
        {
            if (mustacheState)
            {
                badEffects.Add("TAKE Mustache");
                badEffects.Add("TAKE Mustache");
                badEffects.Add("TAKE Mustache");
                badEffects.Add("TAKE Mustache");
            }
            if (shotState)
            {
                badEffects.Add("TAKE Shot");
                badEffects.Add("TAKE Shot");
                badEffects.Add("TAKE Shot");
            }
            if (bottomsUpState)
            {
                badEffects.Add("TAKE BottomsUp");
                badEffects.Add("TAKE BottomsUp");
                badEffects.Add("TAKE BottomsUp");
            }
            if (slammerState)
            {
                badEffects.Add("TAKE Slammer");
                badEffects.Add("TAKE Slammer");
                badEffects.Add("TAKE Slammer");
            }
            if (kingsCupState)
            {
                badEffects.Add("TAKE Kings Cup");
                badEffects.Add("TAKE Kings Cup");
                badEffects.Add("TAKE Kings Cup");
                badEffects.Add("TAKE Kings Cup");
            }
        }

        

       
        
    }
}
