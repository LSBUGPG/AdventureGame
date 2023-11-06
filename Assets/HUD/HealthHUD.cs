using TMPro;
using UnityEngine;

public class HealthHUD : MonoBehaviour
{
    public TMP_Text healthText;

    public void UpdateHealth(float health)
    {
        healthText.text = $"Health: {health.ToString()}";
    }
}
