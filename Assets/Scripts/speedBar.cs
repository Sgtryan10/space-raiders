using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class speedBar : MonoBehaviour
{
    public Image speedFill;
    public Gradient speedGradient;
    public TextMeshProUGUI speedText;

    public ShipMotor ship;
    public float maxSpeed = 100f;

    void Update()
    {
        if (ship != null)
        {
            float currentVelocity = ship.getVelocity();
            float fillPercent = Mathf.Clamp01(currentVelocity / maxSpeed);

            UpdateUI(fillPercent, currentVelocity);
        }
    }

    void UpdateUI(float fillPercent, float rawSpeed)
    {
        speedFill.fillAmount = fillPercent;
        speedFill.color = speedGradient.Evaluate(fillPercent);

        speedText.text = rawSpeed.ToString("F0") + " M/s";
    }
}
