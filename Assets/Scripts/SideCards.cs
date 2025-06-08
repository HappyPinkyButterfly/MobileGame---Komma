using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class SideCards : MonoBehaviour
{
    private GameObject currentCursePrefab;
    private GameObject currentTreasurePrefab;
    private GameObject curretnProtectionPrefab;
    public ComaLite comaLiteScript;
    public RoundStartComp2 roundStartScript;
    public GameEffects gameEffects;

    public bool protectionOn = false;
    public bool curseOn = false;
    public bool treasureOn = false;

    
    public void ProtectionPrefabClick()
    {
        Destroy(gameObject);
    }
    public void ProtectionClick()
    {

        roundStartScript.Reset();
            
        if (curretnProtectionPrefab != null)
        {
            Destroy(curretnProtectionPrefab);
            curretnProtectionPrefab = null;
        }

        foreach (Transform child in roundStartScript.transform)
        {
            if (child.GetComponent<Text>() == null && child.GetComponent<TMP_Text>() == null)
            {
                Destroy(child.gameObject);
            }
        }


        GameObject[] normalProtectionPrefab = Resources.LoadAll<GameObject>("Protection/NormalProtection");
        GameObject[] kingProtectionPrefab = Resources.LoadAll<GameObject>("Protection/King");
        GameObject[] shotProtectionPrefab = Resources.LoadAll<GameObject>("Protection/Shot");
        GameObject[] slammerProtectionPrefab = Resources.LoadAll<GameObject>("Protection/Slam");
        GameObject[] mustacheProtectionPrefab = Resources.LoadAll<GameObject>("Protection/Mustache");
        GameObject[] bottomsUpProtectionPrefab = Resources.LoadAll<GameObject>("Protection/Bottoms");

        List<GameObject> allProtections = new List<GameObject>(normalProtectionPrefab);

        if (gameEffects.mustacheState)
        {
            allProtections.AddRange(mustacheProtectionPrefab);
        }
        if (gameEffects.kingsCupState)
        {
            allProtections.AddRange(kingProtectionPrefab);
        }
        if (gameEffects.shotState)
        {
            allProtections.AddRange(shotProtectionPrefab);
        }
        if (gameEffects.slammerState)
        {
            allProtections.AddRange(slammerProtectionPrefab);
        }
        if (gameEffects.bottomsUpState)
        {
            allProtections.AddRange(bottomsUpProtectionPrefab);
        }




        if (allProtections.Count > 0)
        {
            // Ustvari nov Curse prefab na poziciji ComaLite
            curretnProtectionPrefab = Instantiate(
                allProtections[Random.Range(0, allProtections.Count)],
                roundStartScript.transform.position,
                roundStartScript.transform.rotation,
                roundStartScript.transform
            );
        }
        
    

    }
    public void CurseClick()
    {
        roundStartScript.Reset();

        // Če že imamo Curse prefab, ga uniči
        if (currentCursePrefab != null)
        {
            Destroy(currentCursePrefab);
            currentCursePrefab = null;
        }

        foreach (Transform child in comaLiteScript.transform)
        {
            if (child.GetComponent<Text>() == null && child.GetComponent<TMP_Text>() == null)
            {
                Destroy(child.gameObject);
            }
        }



        GameObject[] normalCurse = Resources.LoadAll<GameObject>("Curse/NormalCurse");
        GameObject[] kingCurse = Resources.LoadAll<GameObject>("Curse/King");
        GameObject[] shotCurse = Resources.LoadAll<GameObject>("Curse/Shot");
        GameObject[] slamCurse = Resources.LoadAll<GameObject>("Curse/Slam");
        GameObject[] mustacheCurse = Resources.LoadAll<GameObject>("Curse/Mustache");
        GameObject[] bottomsCurse = Resources.LoadAll<GameObject>("Curse/Bottoms");

        List<GameObject> allCurses = new List<GameObject>(normalCurse);

        if (gameEffects.mustacheState)
        {
            allCurses.AddRange(mustacheCurse);
        }
        if (gameEffects.kingsCupState)
        {
            allCurses.AddRange(kingCurse);
        }
        if (gameEffects.shotState)
        {
            allCurses.AddRange(shotCurse);
        }
        if (gameEffects.slammerState)
        {
            allCurses.AddRange(slamCurse);
        }
        if (gameEffects.bottomsUpState)
        {
            allCurses.AddRange(bottomsCurse);
        }

        if (allCurses.Count > 0)
        {
            // Ustvari nov Curse prefab na poziciji ComaLite
            currentCursePrefab = Instantiate(
                allCurses[Random.Range(0, allCurses.Count)],
                comaLiteScript.transform.position,
                comaLiteScript.transform.rotation,
                comaLiteScript.transform
            );
        }
        
      
    }
    public void TreasureClcik()
    {
        roundStartScript.Reset();

        if (currentTreasurePrefab != null)
        {
            Destroy(currentTreasurePrefab);
            currentTreasurePrefab = null;
        }

        // Uniči vse obstoječe prefabe na ComaLite (tudi če jih je ustvaril ComaLite)
        foreach (Transform child in comaLiteScript.transform)
        {
            if (child.GetComponent<Text>() == null && child.GetComponent<TMP_Text>() == null)
            {
                Destroy(child.gameObject);
            }
        }

        
        GameObject[] normalTreasure = Resources.LoadAll<GameObject>("Treasure/NormalTreasure");
        GameObject[] kingTreasure = Resources.LoadAll<GameObject>("Treasure/King");
        GameObject[] shotTreasure = Resources.LoadAll<GameObject>("Treasure/Shot");
        GameObject[] slamTreasure = Resources.LoadAll<GameObject>("Treasure/Slam");
        GameObject[] mustacheTreasure = Resources.LoadAll<GameObject>("Treasure/Mustache");
        GameObject[] bottomsTreasure = Resources.LoadAll<GameObject>("Treasure/Bottoms");

        List<GameObject> allTreasure = new List<GameObject>(normalTreasure);

        if (gameEffects.mustacheState)
        {
            allTreasure.AddRange(mustacheTreasure);
        }
        if (gameEffects.kingsCupState)
        {
            allTreasure.AddRange(kingTreasure);
        }
        if (gameEffects.shotState)
        {
            allTreasure.AddRange(shotTreasure);
        }
        if (gameEffects.slammerState)
        {
            allTreasure.AddRange(slamTreasure);
        }
        if (gameEffects.bottomsUpState)
        {
            allTreasure.AddRange(bottomsTreasure);
        }
        
        if (allTreasure.Count > 0)
        {
            // Ustvari nov Curse prefab na poziciji ComaLite
            currentTreasurePrefab = Instantiate(
                allTreasure[Random.Range(0, allTreasure.Count)],
                comaLiteScript.transform.position,
                comaLiteScript.transform.rotation,
                comaLiteScript.transform
            );
        }
        
    }
}
