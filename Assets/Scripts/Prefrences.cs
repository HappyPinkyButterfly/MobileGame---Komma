using UnityEngine;
using UnityEngine.SceneManagement;

public class Prefrences : MonoBehaviour
{

    public bool competitiveOn = false;
    public bool actionOn = false;


    public static Prefrences Instance;

    public void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
    public void CompetitiveClick()
    {
        actionOn = true;
        competitiveOn = true;
        ToGame();
    }

    public void ActionClick()
    {
        actionOn = true;
        competitiveOn = false;
        ToGame();

    }

    public void CasualClick()
    {
        actionOn = false;
        competitiveOn = false;
        ToGame();
    }
    
    public void ToGame()
    {
        SceneManager.LoadScene("Coma");
    }
    
       

}
