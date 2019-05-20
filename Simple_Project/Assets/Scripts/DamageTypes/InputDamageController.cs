using System.Collections;
using UnityEngine.Events;
using UnityEngine;

public class InputDamageController : MonoBehaviour
{
    [HideInInspector] public UnityEvent Damaged;
    [SerializeField] float _health;
    public float Health => _health;

    private void OnValidate()
    {
        if (_health < 0) _health = 0;
    }

    public InputDamageController (float health)
    {
        _health = health;
    }

    public void ApplyDamage(float damage)
    {
        if (_health > 0)
        {
            if (_health > damage)
                _health -= damage;
            else
                _health = 0;
        }
        Damaged.Invoke();
    }
}
