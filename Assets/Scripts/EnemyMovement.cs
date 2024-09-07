using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    void Update()
    {
       
        transform.Translate(Vector3.down * Time.deltaTime * speed, Space.World);
        if (transform.position.y < -6) 
        { 
            transform.position += new Vector3(0, 10, 0);
            ShowRandomEnemies();
        }
            
            
    }

    private void ShowRandomEnemies()
    {
        int randomNumber = UnityEngine.Random.Range(0,3);

        for (int i = 0; i < transform.childCount; i++)
        {
            Transform currentChild = transform.GetChild(i);
            bool showChild = randomNumber == i;
            currentChild.gameObject.SetActive(showChild);
        }

    }

    private void OnEnable()
    {
        ShowRandomEnemies();
    }

}
