using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerButtons))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rigidbody2D;
    private PlayerButtons _playerButtons;
    private int _currentDirection;
    private int _leftDirection = -1;
    private int _rightDirection = 1;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _playerButtons = GetComponent<PlayerButtons>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(_playerButtons.Left))
            _currentDirection = _leftDirection;
        else if (Input.GetKeyDown(_playerButtons.Right))
            _currentDirection = _rightDirection;

        if (Input.GetKey(_playerButtons.Left) || Input.GetKey(_playerButtons.Right))
            _rigidbody2D.velocity = new Vector2(_currentDirection * _speed, _rigidbody2D.velocity.y);
    }
}
