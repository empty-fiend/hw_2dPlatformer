using UnityEngine;

public class CameraPlayerFollower : MonoBehaviour
{
    private Player _player;

    public void Start()
    {
        _player = FindObjectOfType<Player>();
    }

    public void Update()
    {
        transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y, transform.position.z);
    }
}
