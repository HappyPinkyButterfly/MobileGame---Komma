using System;
using UnityEngine;
using TMPro;

public class FreeSpin : MonoBehaviour
{

    public float RotatePower;
    public float StopPower;
    public TextMeshProUGUI reward;
    public TextMeshProUGUI youWon;
    public GameEffects gameEffects { get; set; }

    private Rigidbody2D rbody;
    int inRotate;

    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        gameEffects = GetComponentInParent<GameEffects>();
        reward.text = "";
        youWon.text = "Click SPIN and do what you win !";
    }

    float t;

    private void Update()
    {
        if (rbody.angularVelocity > 0)
        {
            rbody.angularVelocity -= StopPower * Time.deltaTime;

            rbody.angularVelocity = Math.Clamp(rbody.angularVelocity, 0, 1440);
        }

        if (rbody.angularVelocity == 0 && inRotate == 1)
        {
            t += 1 * Time.deltaTime;
            if (t >= 0.5f)
            {
                GetReward();
                inRotate = 0;
                t = 0;
            }
        }
    }

    public void Rotate()
    {
        if (inRotate == 0)
        {
            rbody.AddTorque(RotatePower);
            inRotate = 1;
        }
        youWon.text = "You won:";
    }

    public void GetReward()
    {
        float rot = transform.eulerAngles.z;
        if (rot > 0 && rot <= 78)
        {
            PrintReward("Jackpot");
        }
        else if (rot > 78 && rot <= 116)
        {
            PrintReward("Bad");
        }
        else if (rot > 116 && rot <= 156)
        {
            PrintReward("Good");
        }
        else if (rot > 156 && rot <= 203)
        {
            PrintReward("Bad");
        }
        else if (rot > 203 && rot <= 243)
        {
            PrintReward("Good");
        }
        else if (rot > 243 && rot <= 280)
        {
            PrintReward("Bad");
        }
        else if (rot > 280 && rot <= 317)
        {
            PrintReward("Good");
        }
        else if (rot > 317 && rot <= 360)
        {
            PrintReward("Bad");
        }
    }

    public void PrintReward(string typeOfReward)
    {
        if (typeOfReward == "Bad")
        {
            reward.text = gameEffects.GenerateRandomEffect(gameEffects.badEffects);

        }
        else if (typeOfReward == "Good")
        {
            reward.text = gameEffects.GenerateRandomEffect(gameEffects.goodEffects);
        }
        else if (typeOfReward == "Jackpot")
        {
            reward.text = gameEffects.GenerateRandomEffect(gameEffects.jackpot);
        }
        else
        {
            reward.text = "Error has occured, contanct SupremeLab Productions";
        }
        if (reward.text.Length > 30)
            {
                reward.fontSize = 78f;

            }
            else
            {
                reward.fontSize = 88f;
            }
    }

}
