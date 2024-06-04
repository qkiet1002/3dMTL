using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWeapon : MonoBehaviour
{
    public GameObject kiem;
    public GameObject sung;
    private void OnTriggerEnter(Collider other)
    {
/*        if (other.CompareTag("Kiem"))
        {
            kiem.SetActive(true);
            sung.SetActive(false);
        }*/
        if (other.CompareTag("Sung"))
        {
            kiem.SetActive(false);
            sung.SetActive(true);
        }
        else
        {
            kiem.SetActive(true);
            sung.SetActive(false);
        }
    }
}
