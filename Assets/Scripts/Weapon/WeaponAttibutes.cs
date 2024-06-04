using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
using Unity.Netcode;

public class WeaponAttributes : NetworkBehaviour
{
    public AttributesManager attributesManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<AttributesManager>().TakeDamage(attributesManager.attack);
        }
    }


}
