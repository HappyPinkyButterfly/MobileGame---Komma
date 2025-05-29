using UnityEngine;

public class StartButton : MonoBehaviour
{
    private bool isCompetitiveMode;
    public void Start()
    {
        isCompetitiveMode = Prefrences.Instance.competitiveOn;
    }
}
  
