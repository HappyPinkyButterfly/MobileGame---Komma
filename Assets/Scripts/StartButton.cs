
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    private bool isCompetitiveMode;
    public Sprite start;
    public Sprite compStart;

    public Image startButton;
    public void Start()
    {
        isCompetitiveMode = Prefrences.Instance.competitiveOn;

        if (!isCompetitiveMode )
        {
            startButton.sprite = start;
        }
        else
        {
            startButton.sprite = compStart;
        }
    }
}
  
