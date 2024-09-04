using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipGetDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("recibi daño");
    }
}
