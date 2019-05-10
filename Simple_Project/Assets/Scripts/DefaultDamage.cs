using UnityEngine;
using System.Collections;

public class DefaultDamage : DamageType
{
    [SerializeField] float _damage;
    public float Damage => _damage;

    public override void SetDamage(float damagedParam)
    {
        damagedParam -= _damage;
    }
}
