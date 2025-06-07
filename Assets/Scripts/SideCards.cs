using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using Unity.VisualScripting;

public class SideCards : MonoBehaviour
{
    private GameObject currentCursePrefab;
    private GameObject currentTreasurePrefab;
    private GameObject curretnProtectionPrefab;
    public ComaLite comaLiteScript;
    public RoundStartComp2 roundStartScript;
    public GameEffects gameEffects;


    public void ProtectionPrefabClick()
    {
        Destroy(gameObject);
    }
    public void ProtectionClick()
    {
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
        // Če že imamo Curse prefab, ga uniči
        if (currentCursePrefab != null)
        {
            Destroy(currentCursePrefab);
            currentCursePrefab = null;
        }

        // Uniči vse obstoječe prefabe na ComaLite (tudi če jih je ustvaril ComaLite)
        foreach (Transform child in comaLiteScript.transform)
        {
            if (child.GetComponent<Text>() == null && child.GetComponent<TMP_Text>() == null)
            {
                Destroy(child.gameObject);
            }
        }

        // Naloži Curse prefabe
        GameObject[] cursePrefabs = Resources.LoadAll<GameObject>("Treasure");
        
        if (cursePrefabs.Length > 0)
        {
            // Ustvari nov Curse prefab na poziciji ComaLite
            currentCursePrefab = Instantiate(
                cursePrefabs[Random.Range(0, cursePrefabs.Length)],
                comaLiteScript.transform.position,
                comaLiteScript.transform.rotation,
                comaLiteScript.transform
            );
        }
    }
    public void TreasureClcik()
    {

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

        
        // Naloži Curse prefabe
        GameObject[] treasurePrefabs = Resources.LoadAll<GameObject>("Curse");
        
        if (treasurePrefabs.Length > 0)
        {
            // Ustvari nov Curse prefab na poziciji ComaLite
            currentTreasurePrefab = Instantiate(
                treasurePrefabs[Random.Range(0, treasurePrefabs.Length)],
                comaLiteScript.transform.position,
                comaLiteScript.transform.rotation,
                comaLiteScript.transform
            );
        }
        
    }
}
