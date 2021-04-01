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

    public float EnemyMoveSpeed = 2f;

    int _wayPointIndex = 0;

    private void Start()
    {
        transform.position = _wayPoints[_wayPointIndex].transform.position;
    }

    private void Update()
    {
        MoveShip();
    }

    //Functions moves the ship
    void MoveShip()
    {
        //Moves the ship to the target waypoint
        transform.position = Vector3.MoveTowards(transform.position, _wayPoints[_wayPointIndex].transform.position, EnemyMoveSpeed * Time.deltaTime);

        //Sets the current waypoint to the next one in line
        if (transform.position == _wayPoints [_wayPointIndex].transform.position)
        {
            _wayPointIndex += 1;
        }

        //Sets the current waypoint back to the first one if the last waypoint has been reached
        if (_wayPointIndex == _wayPoints.Length)
        {
            _wayPointIndex = 0;
        }
    }
}