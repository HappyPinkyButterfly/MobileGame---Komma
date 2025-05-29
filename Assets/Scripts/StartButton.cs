
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartButton : MonoBehaviour
{
    private bool isCompetitiveMode;
    public Sprite start;
    public Sprite compStart;

    public Image startButton;

    public RectTransform button;
    public void Start()
    {
        // Preveri, če Instance obstaja
        if (Prefrences.Instance != null)
        {
            isCompetitiveMode = Prefrences.Instance.competitiveOn;
            UpdateButtonSprite();
        }
    }

    private void UpdateButtonSprite()
    {
        if (!isCompetitiveMode)
        {
            startButton.sprite = start;
            button.sizeDelta = new Vector2(600, 250);
            button.anchoredPosition = new Vector2(0, -170);
        }
        else
        {
            startButton.sprite = compStart;
            button.sizeDelta = new Vector2(700, 450);
            button.anchoredPosition = new Vector2(0, -60);
        }
    }

    public void StartClick()
    {
        if (isCompetitiveMode)
        {
            SceneManager.LoadScene("Competitive");
        }
        else
        {
            SceneManager.LoadScene("ComaLite");
        }
     }
}
  
