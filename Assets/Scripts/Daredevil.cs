using TMPro;
using UnityEngine;

public class Daredevil : MonoBehaviour
{

    public GameEffects gameEffects { get; set; }
    public TextMeshProUGUI one;
    public TextMeshProUGUI two;
    public TextMeshProUGUI three;
    public TextMeshProUGUI four;
    public TextMeshProUGUI effect;
    

    public void Start()
    {

        gameEffects = GetComponentInParent<GameEffects>();

        one.text = gameEffects.GenerateRandomEffect(gameEffects.sideEffectList);
        two.text = gameEffects.GenerateRandomEffect(gameEffects.sideEffectList);
        three.text = gameEffects.GenerateRandomEffect(gameEffects.sideEffectList);
        four.text = gameEffects.GenerateRandomEffect(gameEffects.sideEffectList);

        effect.text = gameEffects.GenerateRandomEffect(gameEffects.goodEffects);
        

        if (one.text.Length > 20)
        {
            one.fontSize = 55f + gameEffects.fontControlSmall;

        }
        else
        {
            one.fontSize = 65f + gameEffects.fontControlBig;
        }

        if (two.text.Length > 20)
        {
            two.fontSize = 55f + gameEffects.fontControlSmall;

        }
        else
        {
            two.fontSize = 65f + gameEffects.fontControlBig;
        }

        if (three.text.Length > 20)
        {
            three.fontSize = 55f + gameEffects.fontControlSmall;

        }
        else
        {
            three.fontSize = 65f + gameEffects.fontControlBig;
        }
        
        if (four.text.Length > 25)
        {
            four.fontSize = 55f + gameEffects.fontControlSmall;

        }
        else
        {
            four.fontSize = 65f + gameEffects.fontControlBig;
        }

        if (effect.text.Length > 25)
        {
            effect.fontSize = 55f + gameEffects.fontControlSmall;

        }
        else
        {
            effect.fontSize = 65f + gameEffects.fontControlBig;
        }
    }   
}
