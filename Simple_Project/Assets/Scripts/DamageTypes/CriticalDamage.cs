using UnityEngine;
using System.Collections;

[RequireComponent(typeof(DefaultDamage))]
public class CriticalDamage : DamageType
{
    DefaultDamage defaultDamage;

    public CriticalDamage(float damageScale)
    {
        _damageScale = damageScale;
    }

    private void Start()
    {
        defaultDamage = GetComponent<DefaultDamage>();
    }

    [SerializeField] float _damageScale;
    public float DamageScale => _damageScale;
    public override void SetDamage(InputDamageController target)
    {
        target.ApplyDamage(defaultDamage.Damage * _damageScale);
    }
}
