using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVariationMovement : MonoBehaviour
{

    public float variant = 1;

    void Update()
    {
        transform.position += Vector3.left *
            Mathf.Sin(Time.time) *
            Time.deltaTime * variant;
    }
}
