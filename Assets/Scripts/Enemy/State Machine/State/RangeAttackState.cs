using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class RangeAttackState : State
{
    [SerializeField] private float _delay;
    [SerializeField] private Transform _spitPoint;
    [SerializeField] private Spit _spit;

    private float _lastAttackTime;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.Play(AnimatorEnemy.States.Attack);
        if (_lastAttackTime <= 0)
        {
            Instantiate(_spit, _spitPoint.position, _spit.transform.rotation);
            _lastAttackTime = _delay;
        }

        _lastAttackTime -= Time.deltaTime;
    }
}
