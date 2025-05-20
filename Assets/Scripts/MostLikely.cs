using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MostLikely : MonoBehaviour
{
    public TextMeshProUGUI effect;
    public TextMeshProUGUI description;

    public List<string> effectList = new List<string>
    {

    };
    public List<string> descriptionList = new List<string>
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
        "Biggest whore or fuckboy"
    };

    public void Start()
    {
        int index = Random.Range(0, descriptionList.Count);
        description.text = descriptionList[index];
    }
}
