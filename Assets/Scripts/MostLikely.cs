using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MostLikely : MonoBehaviour
{
    public TextMeshProUGUI effect;
    public TextMeshProUGUI description;
    public GameEffects gameEffects;
    public void Awake()
    {
        gameEffects = GetComponentInParent<GameEffects>();

    }

    public List<string> effectList = new List<string>
    {

    };
    

    public void Start()
    {
        int index = Random.Range(0, gameEffects.descriptionList.Count);
        description.text = gameEffects.descriptionList[index];
    }
}
