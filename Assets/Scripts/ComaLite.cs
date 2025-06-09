
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class ComaLite : MonoBehaviour
{
    public GameEffects gameEffects { get; set; }
    public RoundStartComp2 roundStartComp2;
    public RectTransform comaLite;
    
     public CanvasGroup treasure;
    public CanvasGroup protection;
    public CanvasGroup curse;

    public void Start()
    {
        if (!gameEffects.actionState)
        {
            treasure.alpha = 0f;
            treasure.blocksRaycasts = false;
            treasure.interactable = false;

            protection.alpha = 0f;
            protection.blocksRaycasts = false;
            protection.interactable = false;

            curse.alpha = 0f;
            curse.blocksRaycasts = false;
            curse.interactable = false;


        }
        else
        {
            treasure.alpha = 1f;
            treasure.blocksRaycasts = true;
            treasure.interactable = true;

            protection.alpha = 1f;
            protection.blocksRaycasts = true;
            protection.interactable = true;

            curse.alpha = 1f;
            curse.blocksRaycasts = true;
            curse.interactable = true;
        }
    }

    public void Awake()
    {
        gameEffects = GetComponentInParent<GameEffects>();
    }

    public void LoadRandomPrefab()
    {
        foreach (Transform child in transform)
        {
            if (child.GetComponent<Text>() == null && child.GetComponent<TMP_Text>() == null)
            {
                Destroy(child.gameObject);
            }
        }

        if (!gameEffects.comaLite)
        {
            GameObject[] normalComa = Resources.LoadAll<GameObject>("Coma/NormalComa");
            GameObject[] kingComa = Resources.LoadAll<GameObject>("Coma/King");
            GameObject[] shotComa = Resources.LoadAll<GameObject>("Coma/Shot");
            GameObject[] slamComa = Resources.LoadAll<GameObject>("Coma/Slam");
            GameObject[] mustacheComa = Resources.LoadAll<GameObject>("Coma/Mustache");
            GameObject[] bottomsComa = Resources.LoadAll<GameObject>("Coma/Bottoms");
            GameObject[] actionComa = Resources.LoadAll<GameObject>("Coma/Action");
            

            List<GameObject> allComa = new List<GameObject>(normalComa);

            if (gameEffects.mustacheState)
            {
                allComa.AddRange(mustacheComa);
            }
            if (gameEffects.kingsCupState)
            {
                allComa.AddRange(kingComa);
            }
            if (gameEffects.shotState)
            {
                allComa.AddRange(shotComa);
            }
            if (gameEffects.slammerState)
            {
                allComa.AddRange(slamComa);
            }
            if (gameEffects.bottomsUpState)
            {
                allComa.AddRange(bottomsComa);
            }
            if (gameEffects.actionState)
            {
                allComa.AddRange(actionComa);
            }
            

            if (allComa.Count > 0)
                {
                    GameObject randomPrefab = allComa[Random.Range(0, allComa.Count)];
                    Instantiate(randomPrefab, transform);
                }
        }
        gameEffects.comaLite = !gameEffects.comaLite;
        if (!gameEffects.comaLite)
        {
            gameEffects.roundStart = !gameEffects.roundStart;

            roundStartComp2.Reset();
        } 
    }
}
