using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    Slider _healthBar;
    float maxHealth;
    InputDamageController player;

    private void Start()
    {
        _healthBar = GetComponent<Slider>();
        player = GameObject.FindObjectOfType<InputDamageController>();
        maxHealth = player.Health;
        UpdateHealthBar();
        player.Damaged.AddListener(() => UpdateHealthBar());
    }

    void UpdateHealthBar()
    {
        float percentOfHealth = maxHealth / 100;
        _healthBar.value = player.Health / percentOfHealth;
    }
}
