using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnergyHUD : MonoBehaviour
{
    public TMP_Text energyText;

    public void UpdateEnergy(float energy)
    {
        energyText.text = $"Energy: {energy.ToString()}";
    }
}
