using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemy : MonoBehaviour
{
    private ShipFire _shipFire;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object Found");
        if (other.tag == StringManager.enemyTag)
        {
            Debug.Log("Enemy Found");
            _shipFire = GetComponentInParent<ShipFire>();
            _shipFire.target = other.gameObject;
        }
    }
}
