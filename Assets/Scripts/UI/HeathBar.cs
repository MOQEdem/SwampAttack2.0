using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeathBar : Bar
{
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.HeathChanged += OnValueChanged;
        Slider.value = 1;
    }

    private void OnDisable()
    {
        _player.HeathChanged -= OnValueChanged;        
    }
}
