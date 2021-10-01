using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _characterToSpawn;

    private void Awake()
    {
        Instantiate(_characterToSpawn, transform);
    }
}