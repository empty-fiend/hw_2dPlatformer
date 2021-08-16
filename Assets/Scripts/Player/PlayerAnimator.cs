using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(PlayerButtons))]
public class PlayerAnimator : MonoBehaviour
{
    private Animator _animator;
    private PlayerButtons _playerButtons;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _playerButtons = GetComponent<PlayerButtons>();
    }

    private void Update()
    {
        _animator.SetBool("IsWalking", Input.GetKey(_playerButtons.Right) || Input.GetKey(_playerButtons.Left));
    }
}
