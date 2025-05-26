
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class ComaLite : MonoBehaviour
{
    public GameEffects gameEffects { get; set; }
    
    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
    }

    public void LoadRandomPrefab()
    {
        if (gameEffects.roundStart)
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
                GameObject[] allPrefabs = Resources.LoadAll<GameObject>("Prefabs");
                if (allPrefabs.Length > 0)
                {
                    GameObject randomPrefab = allPrefabs[Random.Range(0, allPrefabs.Length)];
                    Instantiate(randomPrefab, transform);
                }
            }
            gameEffects.comaLite = !gameEffects.comaLite;

        }
        

        if (!gameEffects.comaLite)
        {
            gameEffects.roundStart = !gameEffects.roundStart;
        }
        
    }
}
