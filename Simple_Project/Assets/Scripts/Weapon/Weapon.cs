using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    protected DamageType _damageType;

    protected virtual void Start()
    {
        if (!GetComponent<DamageType>())
            _damageType = new DefaultDamage(10);
        else
            _damageType = GetComponent<DamageType>();
    }
}
