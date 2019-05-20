using UnityEngine;
using System.Collections;

public class PoisonDamage : DamageType
{
    InputDamageController currentTarget;
    [SerializeField] float _damageOnTick = 5;
    public float DamageOnTick => _damageOnTick;
    [SerializeField] float _poisonEffectDuration = 5;
    public float PoisonEffectDuration => _poisonEffectDuration;

    public override void SetDamage(InputDamageController target)
    {
        currentTarget = target;
        StartCoroutine("PoisonDamageEffect");
    }

    IEnumerator PoisonDamageEffect()
    {
        InvokeRepeating("PoisonTick", 1, 1);
        yield return new WaitForSeconds(_poisonEffectDuration);
        CancelInvoke("PoisonTick");
    }

    void PoisonTick()
    {
        currentTarget.ApplyDamage(_damageOnTick);
    }
}
