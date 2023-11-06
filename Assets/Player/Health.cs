using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    public HealthHUD healthHUD;
    float health = 100f;
    Coroutine burning;

    void Start()
    {
        healthHUD.UpdateHealth(health);
    }

    public void Burn()
    {
        if (burning == null)
        {
            burning = StartCoroutine(Burning());
        }
    }

    IEnumerator Burning()
    {
        health -= 10f;
        healthHUD.UpdateHealth(health);
        yield return new WaitForSeconds(1f);
        burning = null;
    }

    public void Heal(float health)
    {
        this.health += health;
        healthHUD.UpdateHealth(this.health);
    }
}
