using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerGroundChecker))]
[RequireComponent(typeof(PlayerButtons))]
public class PlayerJumper : MonoBehaviour
{
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody2D;
    private PlayerGroundChecker _playerGroundChecker;
    private PlayerButtons _playerButtons;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _playerGroundChecker = GetComponent<PlayerGroundChecker>();
        _playerButtons = GetComponent<PlayerButtons>();
    }

    private void Update()
    {
        if (Input.GetKey(_playerButtons.Jump) && _playerGroundChecker.IsGrounded)
        {
            _rigidbody2D.AddForce(new Vector2(transform.position.x, _jumpForce), ForceMode2D.Impulse);
        }
    }
}
