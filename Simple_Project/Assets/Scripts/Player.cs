using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float _health;
    public float Health => _health;

    public void ApplyDamage(DamageType damageType)
    {
        damageType.SetDamage(_health);
    }
}
