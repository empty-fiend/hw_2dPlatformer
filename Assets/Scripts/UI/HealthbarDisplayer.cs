using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthbarDisplayer : MonoBehaviour
{
    [SerializeField] private float _changeSpeed;

    private Slider _healthbar;
    private Player _player;

    private void Awake()
    {
        _player = FindObjectOfType<Player>();
        _healthbar = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _player.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnHealthChanged;
    }

    private void OnHealthChanged(float value)
    {
        if (_healthbar.maxValue < value)
        {
            _healthbar.maxValue = value;
        }

        if (_healthbar.value != value)
        {
            StartCoroutine(Filling(value));
        }
    }

    private IEnumerator Filling(float endValue)
    {
        while (_healthbar.value != endValue)
        {
            _healthbar.value = Mathf.MoveTowards(_healthbar.value, endValue, _changeSpeed * Time.deltaTime);
            yield return null;
        }
    }
}