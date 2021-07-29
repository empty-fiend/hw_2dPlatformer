using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerCheckGrounded))]
public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody2D;
    private PlayerCheckGrounded _playerCheckGrouned;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _playerCheckGrouned = GetComponent<PlayerCheckGrounded>();
    }

    private void Update()
    {
        if (Input.GetButton("Jump") && _playerCheckGrouned.IsGrounded)
        {
            _rigidbody2D.AddForce(new Vector2(transform.position.x, _jumpForce), ForceMode2D.Impulse);
        }
    }
}
