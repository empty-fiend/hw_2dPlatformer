using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float _maxHealthAmount;
    private float _healthAmount;

    public float HealthAmount => _healthAmount;

    private void Awake()
    {
        _healthAmount = _maxHealthAmount;
    }

    public void HealthDecrease (float damageAmount)
    {
        if (_healthAmount > damageAmount)
        {
            _healthAmount -= damageAmount;
        }
        else
        {
            _healthAmount -= _healthAmount;
        }
    }

    public void HeathIncrease (float healAmount)
    {
        if (_healthAmount + healAmount > _maxHealthAmount)
            _healthAmount = _maxHealthAmount;
        else
            _healthAmount += healAmount;
    }
}