using UnityEngine;

public class PlayerHealthChanger : MonoBehaviour
{
    [SerializeField] private float _healthChangeAmount;

    private PlayerHealth _playerHealth;

    private void Start()
    {
        FindObjectOfType<Player>().TryGetComponent<PlayerHealth>(out _playerHealth);
    }

    public void IncreaseHealth()
    {
        _playerHealth.HeathIncrease(_healthChangeAmount);
    }

    public void DecreaseHealth()
    {
        _playerHealth.HealthDecrease(_healthChangeAmount);
    }
}
