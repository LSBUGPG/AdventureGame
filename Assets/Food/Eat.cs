using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    public EnergyHUD energyHUD;
    public Health health;
    public float maxEnergy = 2000f;
    float energy;

    public void Consume(float food)
    {
        energy = Mathf.Min(energy + food, maxEnergy);
        UpdateEnergyHUD();
    }

    void UpdateEnergyHUD()
    {
        if (energyHUD != null)
        {
            energyHUD.UpdateEnergy(energy);
        }
    }

    void Start()
    {
        energy = maxEnergy;
        UpdateEnergyHUD();
        StartCoroutine(Heal());
    }

    IEnumerator Heal()
    {
        while (energy > 0)
        {
            yield return new WaitForSeconds(1f);
            energy -= 1f;
            health.Heal(1f);
            UpdateEnergyHUD();
        }
        // out of energy: game over
    }
}
