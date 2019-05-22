using UnityEngine;
using System.Collections;

public class MeleeWeapon : Weapon
{
    private bool isDanger;

    public void EnableDanger()
    {
        isDanger = true;
    }

    public void DisableDanger()
    {
        isDanger = false;
    }

    PlayerEventController _playerEventController;

    protected override void Start()
    {
        base.Start();
        _playerEventController = GetComponentInParent<PlayerEventController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isDanger)
        {
            if (collision.transform.CompareTag("Enemy"))
            {
                _damageType.SetDamage(collision.transform.GetComponent<InputDamageController>());
            }
        }
    }
}
