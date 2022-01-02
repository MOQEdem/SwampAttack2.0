using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectDieTransition : Transition
{
    [SerializeField] private Enemy _object;

    private void OnEnable()
    {
        _object.Dying += ActivateTransition;
    }

    private void OnDisable()
    {
        _object.Dying -= ActivateTransition;
    }

    private void ActivateTransition(Enemy enemy)
    {
        NeedTransit = true;
    }
}
