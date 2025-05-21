using System.Collections.Generic;
using UnityEngine;

public class GameEffects : MonoBehaviour
{
    public List<string> badEffects;

    public void Awake()
    {
       badEffects = new List<string>
        {
            "All diffrent genders take a photo with you and 5 sips",
            "Take a photo with the person closest to you body count and 3 sips",
            "Take sips equal to the continets you visited",
            "Draw Round Start for each player present",
            "Take photo with the youngest player, make cute faces and SHOT",
            "Draw 3 Round Starts",
            "Draw 2 Round Starts",
            "Take 6 Sips",
            "Take 5 Sips",
            "Take 4 Sips",
            "Take 3 Sips",
            "Chug 5 Seconds",
            "Chug 4 Seconds",
            "Chug 3 Seconds",
            "Take SHOT",
            "Bottoms Up",
        };
    }



    public List<string> goodEffects = new List<string>
    {
        "Give 3 Round Starts",
        "Give 2 Round Starts",
        "Give 6 Sips",
        "Give 5 Sips",
        "Give 4 Sips",
        "Give 3 Sips",
        "Give Chug 5 Seconds",
        "Give Chug 4 Seconds",
        "Give Chug 3 Seconds",
        "Give Take SHOT",
        "Give Bottoms Up",
        "All diffrent genders take a photo with you and give 5 sips",
        "Take a photo with the person closest to you body count and give 3 sips",
        "Give sips equal to the continets you visited",
        "Give Round Start for each player present"
    };
}
