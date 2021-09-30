using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthbarDisplayer : MonoBehaviour
{
    [SerializeField] private float _healthbarValueChangeSpeed;

    private Slider _healthbar;
    private PlayerHealth _playerHealth;

    private void Start()
    {
        FindObjectOfType<Player>().TryGetComponent<PlayerHealth>(out _playerHealth);
        _healthbar = GetComponent<Slider>();

        _healthbar.maxValue = _playerHealth.HealthAmount;
        _healthbar.value = _healthbar.maxValue;
    }

    private void Update()
    {
        if (_playerHealth.HealthAmount != _healthbar.value)
        {
            _healthbar.value = Mathf.MoveTowards(_healthbar.value, _playerHealth.HealthAmount, _healthbarValueChangeSpeed * Time.deltaTime);
        }
    }
}