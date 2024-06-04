using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using Unity.VisualScripting;
public class EnemyAttackAttributes : NetworkBehaviour
{
    public AttributesManager attributesManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<AttributesManager>().TakeDamage(attributesManager.attack);
        }
    }
}
