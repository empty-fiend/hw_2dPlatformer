using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private int _coinCount;
    [SerializeField] private float _distanceBetweenCoins;
    [SerializeField] private Coin _template;

    private float _newSpawnPosition;

    private void Start()
    {
        _newSpawnPosition = transform.position.x; 
        
        for (int i = 0; i < _coinCount; i++)
        {
            Instantiate(_template, new Vector3(_newSpawnPosition, transform.position.y), Quaternion.identity);
            _newSpawnPosition += _distanceBetweenCoins;
        }
    }
}
