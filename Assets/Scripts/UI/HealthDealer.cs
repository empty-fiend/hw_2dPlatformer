using UnityEngine;

public class HealthDealer : MonoBehaviour
{
    [SerializeField] private float _healthChangeAmount;

    private Player _player;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
    }

    public void IncreaseHealth()
    {
        _player.IncreaseHealth(_healthChangeAmount);
    }

    public void DecreaseHealth()
    {
        _player.DecreaseHealth(_healthChangeAmount);
    }
}
