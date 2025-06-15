using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class RedGreen : MonoBehaviour
{
    public GameEffects gameEffects { get; set; }
    public TextMeshProUGUI onee;
    public TextMeshProUGUI twoo;
    public TextMeshProUGUI threee;
    public TextMeshProUGUI fourr;

    public Image o;
    public Image t;
    public Image th;
    public Image f;
    public Sprite red;
    public Sprite green;

    public void Start()
    {
        gameEffects = GetComponentInParent<GameEffects>();
        int one = Random.Range(0, 2);
        int two = Random.Range(0, 2);
        int three = Random.Range(0, 2);
        int four = Random.Range(0, 2);

        if (one == 0)
        {
            o.sprite = red;
        }
        else
        {
            o.sprite = green;
        }

        if (two == 0)
        {
            t.sprite = red;
        }
        else
        {
            t.sprite = green;
        }

        if (three == 0)
        {
            th.sprite = red;
        }
        else
        {
            th.sprite = green;
        }

        if (four == 0)
        {
            f.sprite = red;
        }
        else
        {
            f.sprite = green;
        }

        onee.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        twoo.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        threee.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
        fourr.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);
    }
}
