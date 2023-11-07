using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    public HealthHUD healthHUD;
    public float maxHealth = 100f;
    float health;
    Coroutine burning;

    void Start()
    {
        health = maxHealth;
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

    public void Heal(float heal)
    {
        if (health < maxHealth)
        {
            health = Mathf.Min(health + heal, maxHealth);
            healthHUD.UpdateHealth(health);
        }
    }
}
