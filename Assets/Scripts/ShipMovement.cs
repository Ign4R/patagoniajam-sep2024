using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public Vector2 HandleForce;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)){
            GetComponent<Rigidbody2D>().AddForce(-HandleForce);
         
            Debug.Log("moviendo derecha");
        }

        if (Input.GetKeyDown(KeyCode.D)) {
            GetComponent<Rigidbody2D>().AddForce(HandleForce);
            Debug.Log("moviendo izquierda");
        }
    }
}
