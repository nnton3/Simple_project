using UnityEngine;
using System.Collections;

[RequireComponent(typeof(DefaultDamage))]
public class CriticalDamage : DamageType
{
    DefaultDamage defaultDamage;

    private void Start()
    {
        defaultDamage.GetComponent<DefaultDamage>();
    }

    [SerializeField] float damageScale;
    public override void SetDamage(float damagedParam)
    {
        damagedParam -= (defaultDamage.Damage * damageScale);
    }
}
