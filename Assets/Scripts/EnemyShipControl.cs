using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves the enemy ships along the given waypoints
/// </summary>
public class EnemyShipControl : MonoBehaviour
{
    [SerializeField]
    Transform[] _wayPoints;

    [SerializeField]
    float _moveSpeed = 2f;

    int _wayPointIndex = 0;

    private void Start()
    {
        transform.position = _wayPoints[_wayPointIndex].transform.position;
    }

    private void Update()
    {
        MoveShip();
    }

    void MoveShip()
    {
        transform.position = Vector3.MoveTowards(transform.position, _wayPoints[_wayPointIndex].transform.position, _moveSpeed * Time.deltaTime);

        if (transform.position == _wayPoints [_wayPointIndex].transform.position)
        {
            _wayPointIndex += 1;
        }

        if (_wayPointIndex == _wayPoints.Length)
        {
            _wayPointIndex = 0;
        }
    }
}