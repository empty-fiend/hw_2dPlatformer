using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealthAmount;
    private float _healthAmount;

    public event UnityAction<float> HealthChanged;

    public float HealthAmount => _healthAmount;


    private void Start()
    {
        _healthAmount = _maxHealthAmount;
        HealthChanged?.Invoke(_healthAmount);
    }

    public void DecreaseHealth(float damageAmount)
    {
        if (_healthAmount > damageAmount)
            _healthAmount -= damageAmount;
        else
            _healthAmount -= _healthAmount;

        HealthChanged?.Invoke(_healthAmount);
    }

    public void IncreaseHealth(float healAmount)
    {
        if (_healthAmount + healAmount > _maxHealthAmount)
            _healthAmount = _maxHealthAmount;
        else
            _healthAmount += healAmount;

        HealthChanged?.Invoke(_healthAmount);
    }
}