using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class ComaLite : MonoBehaviour
{
    public void LoadRandomPrefab()
    {
        foreach (Transform child in transform)
    {
        // Preveri, če otrok NI text (npr. nima komponente Text/TMP_Text)
        if (child.GetComponent<Text>() == null && child.GetComponent<TMP_Text>() == null)
        {
            Destroy(child.gameObject);
        }
    }
        // 1. Naloži VSE prefabe iz mape "Resources/Prefabs/"
        GameObject[] allPrefabs = Resources.LoadAll<GameObject>("Prefabs");

        GameObject randomPrefab = allPrefabs[Random.Range(0, allPrefabs.Length)];

        // 4. Ustvari instanco v sceni
        Instantiate(randomPrefab, transform);
    }
}
