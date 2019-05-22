using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationController : MonoBehaviour
{
    PlayerEventController _playerEventController;
    Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _playerEventController = GetComponentInParent<PlayerEventController>();
        _playerEventController.Attack.AddListener(() => _animator.SetTrigger("attack"));
    }
}
