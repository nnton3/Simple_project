using UnityEngine;
using System.Collections;

public class DefaultDamage : DamageType
{
    [SerializeField] float _damage;
    public float Damage => _damage;

    public DefaultDamage(float damage)
    {
        _damage = damage;
    }

    public override void SetDamage(Player target)
    {
        target.ApplyDamage(_damage);
    }
}
