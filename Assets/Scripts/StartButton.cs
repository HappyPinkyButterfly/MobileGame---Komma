
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartButton : MonoBehaviour
{
    public Image startButton;

    public RectTransform button;

    public void StartClick()
    {
        SceneManager.LoadScene("Coma");
    }
}
