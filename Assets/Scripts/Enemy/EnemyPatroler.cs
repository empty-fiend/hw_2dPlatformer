using UnityEngine;

public class EnemyPatroler : MonoBehaviour
{
    [SerializeField] private float _terretoryToPatrol;
    [SerializeField] private float _speed;

    private float[] _patrolPoints;
    private int _currentDirection;

    private void Start()
    {
        _patrolPoints = new float[] 
        { 
            transform.position.x + _terretoryToPatrol / 2, 
            transform.position.x - _terretoryToPatrol / 2
        };
    }

    private void Update()
    {
        var target = new Vector3(_patrolPoints[_currentDirection], transform.position.y);

        transform.position = Vector3.MoveTowards(transform.position, target, _speed * Time.deltaTime);

        if (transform.position == target)
        {
            _currentDirection++;

            if (_currentDirection >= _patrolPoints.Length)
            {
                _currentDirection = 0;
            }
        }
    }
}
