using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFire : MonoBehaviour
{
    public GameObject target { get; set; }

    public void Update()
    {
        if (target != null)
        {
            this.gameObject.transform.LookAt(target.transform);
            Shoot();
        }
    }

    private float _shootCooldown = 100f;

    private void Shoot()
    {
        if (_shootCooldown <= 0)
        {
            Destroy(target); //TODO: replace with HP
        }
        else
        {
            _shootCooldown--;
        }
    }
}
