using UnityEngine;
using System.Collections.Generic;

public class Enemy : MonoBehaviour
{
    [SerializeField] InputDamageController player;

    [SerializeField] List<DamageType> damageTypes;

    public void DefaultAttack()
    {
        if (damageTypes.Count > 0)
        {
            damageTypes[0].SetDamage(player);
        }
    }

    public void CriticalAttack()
    {
        if (damageTypes.Count > 1)
        {
            damageTypes[1].SetDamage(player);
        }
    }

    public void PoisonAttack()
    {
        if (damageTypes.Count > 2)
        {
            damageTypes[2].SetDamage(player);
        }
    }
}