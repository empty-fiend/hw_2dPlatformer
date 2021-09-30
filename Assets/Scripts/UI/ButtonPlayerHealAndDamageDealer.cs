using UnityEngine;

public class ButtonPlayerHealAndDamageDealer : MonoBehaviour
{
    [SerializeField] private float _healthChangeAmount;

    private PlayerHealth _playerHealth;

    private void Start()
    {
        FindObjectOfType<Player>().TryGetComponent<PlayerHealth>(out _playerHealth);
    }

    public void IncreaseHealth()
    {
        _playerHealth.IncreaseHealth(_healthChangeAmount);
    }

    public void DecreaseHealth()
    {
        _playerHealth.DecreaseHealth(_healthChangeAmount);
    }
}
