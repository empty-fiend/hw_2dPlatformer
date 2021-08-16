using UnityEngine;

[RequireComponent(typeof(PlayerButtons))]
public class PlayerDirectionChanger : MonoBehaviour
{
    private float _newPlayerScaleX;
    private PlayerButtons _playerButtons;

    private void Start()
    {
        _playerButtons = GetComponent<PlayerButtons>();
        _newPlayerScaleX = transform.localScale.x;
    }
    private void Update()
    {
        if (Input.GetKeyDown(_playerButtons.Right))
            _newPlayerScaleX = 1;
        else if (Input.GetKeyDown(_playerButtons.Left))
            _newPlayerScaleX = -1;

        transform.localScale = new Vector3(_newPlayerScaleX, 1, 1);
    }
}
