using UnityEngine;

public class PlayerDirectionChanger : MonoBehaviour
{
    private float _newPlayerScaleX;

    private void Start()
    {
        _newPlayerScaleX = transform.localScale.x;
    }
    private void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
            _newPlayerScaleX = 1;
        else if (Input.GetAxis("Horizontal") < 0)
            _newPlayerScaleX = -1;

        transform.localScale = new Vector3(_newPlayerScaleX, 1, 1);
    }
}
