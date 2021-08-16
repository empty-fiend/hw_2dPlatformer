using UnityEngine;

public class PlayerGroundChecker : MonoBehaviour
{
    [SerializeField] private LayerMask _groundLayer;

    private bool _isGrounded;
    private Vector2 _transformDown;
    private int _rayDistance = 1;

    public bool IsGrounded => _isGrounded;

    private void Start()
    {
        _transformDown = transform.up * -1;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        _isGrounded = Physics2D.Raycast(transform.position, _transformDown, _rayDistance, _groundLayer);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _isGrounded = false;
    }
}
