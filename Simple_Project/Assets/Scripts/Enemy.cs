using UnityEngine;
using System.Collections.Generic;

public class Enemy : MonoBehaviour
{
    [SerializeField] Player player;

    [SerializeField] List<DamageType> damageTypes;

    public void Attack()
    {
        if (damageTypes.Count > 0)
        {
            var currentDamageType = damageTypes[Random.Range(0, damageTypes.Count)];
            player.ApplyDamage(currentDamageType);
        }
    }
}
