using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ComaLite : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public string typeOfComa { get; set; }

    public List<Button> comaPrefabs;
    private GameObject currentInstance;
    public List<string> typeOfComaLsit = new List<string>
    {
        "Categories",
        "Medusa",
        "Game of 3",
        "Most likey",
        "Shiritori",
        "Stare contest",
        "Challanger",
        "Guess underwear colour",
        "Truth",
        "Shot",
        "Waterfall"
     };

    public void ComaLiteClick()
    {
        if (currentInstance != null)
            Destroy(currentInstance);
        //GameObject randomPrefab = comaPrefabs[Random.Range(0, comaPrefabs.Count)];
        //currentInstance =  Instantiate(
                randomPrefab,
                transform.position,
                transform.rotation,
                transform.parent);
    }
    
        


        
    }


}
