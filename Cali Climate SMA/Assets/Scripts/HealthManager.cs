using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image healthBar;

    public float healthAmount = 100f;

    public void TakeDamage(float damage){
        if (healthAmount > 0){
            healthAmount -= damage;
            healthBar.fillAmount = healthAmount / 100f;
        }
    }

    public void Heal(float damage){
        if (healthAmount < 100){
            healthAmount += damage;
            healthAmount = Mathf.Clamp(healthAmount, 0, 100);
            healthBar.fillAmount = healthAmount / 100f;
        }
    }
}
