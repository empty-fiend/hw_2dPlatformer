using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    private Vector3 _playerPoistion;

    public void Start()
    {
        _playerPoistion = FindObjectOfType<Player>().transform.position;
    }

    public void Update()
    {
        transform.position = new Vector3(_playerPoistion.x, _playerPoistion.y, transform.position.z);
    }
}
