using UnityEngine;

public class PlayerButtons : MonoBehaviour
{
    [SerializeField] private KeyCode _left = KeyCode.A;
    [SerializeField] private KeyCode _right = KeyCode.D;
    [SerializeField] private KeyCode _jump = KeyCode.Space;

    public KeyCode Left { get { return _left; } }
    public KeyCode Right { get { return _right; } }
    public KeyCode Jump { get { return _jump; } }
}
