using UnityEngine;

public class PlayerCheckGrounded : MonoBehaviour
{
    [SerializeField] private LayerMask _groundLayer;

    private bool _isGrounded;

    public bool IsGrounded => _isGrounded;

    private void OnCollisionStay2D(Collision2D collision)
    {
        var hit = Physics2D.Raycast(transform.position, transform.up * -1, 1, _groundLayer);

        _isGrounded = hit;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _isGrounded = false;
    }
}
