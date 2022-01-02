using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(BoxCollider2D))]

public class DeathState : State
{
    [SerializeField] private float _deathTimeAnimation;

    private Animator _animator;
    private BoxCollider2D _boxCollider2D;

    private void Start()
    {
        StartCoroutine(DestroyObject());
        _animator = GetComponent<Animator>();
        _boxCollider2D = GetComponent<BoxCollider2D>();

        _animator.Play(AnimatorEnemy.States.Death);
        _boxCollider2D.enabled = false;
    }

    private IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(_deathTimeAnimation);

        Destroy(gameObject);
    }
}
