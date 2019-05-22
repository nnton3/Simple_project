using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    Slider _healthBar;
    float maxHealth;
    InputDamageController _inputDamageController;

    private void Start()
    {
        _healthBar = GetComponent<Slider>();
        _inputDamageController = GetComponentInParent<InputDamageController>();
        maxHealth = _inputDamageController.Health;
        UpdateHealthBar();
        _inputDamageController.Damaged.AddListener(() => UpdateHealthBar());
    }

    void UpdateHealthBar()
    {
        float percentOfHealth = maxHealth / 100;
        _healthBar.value = _inputDamageController.Health / percentOfHealth;
    }
}
