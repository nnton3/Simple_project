using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveController : MonoBehaviour
{
    protected Vector2 _input;
    [SerializeField] float _movespeed;
    [SerializeField] float _angularSpeed;
    protected float _rotateDirection;
    Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    protected virtual void Update()
    {
        Rotate();
        Move();        
    }

    void Move()
    {
        var moveVector = _input * _movespeed;
        _rb.velocity = transform.TransformDirection(new Vector3 (moveVector.x, _rb.velocity.y, moveVector.y));
    }

    void Rotate()
    {
        Quaternion targetPositionAngle = Quaternion.Euler(new Vector3(transform.eulerAngles.x,
                                                                      transform.eulerAngles.y + _angularSpeed * _rotateDirection,
                                                                      transform.eulerAngles.z));
        transform.rotation = Quaternion.Lerp(transform.rotation, targetPositionAngle, Time.deltaTime);
    }
}
