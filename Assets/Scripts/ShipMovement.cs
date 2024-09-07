using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public Vector2 moveSpeed = new Vector2(5f, 0f);  // Velocidad de movimiento del barco
    public AudioSource audioSource; // Referencia al AudioSource (puedes asignarlo desde el Inspector)

    void Update()
    {
        Vector2 movement = Vector2.zero;

        // Movimiento hacia la izquierda
        if (Input.GetKey(KeyCode.A))
        {
            movement = -moveSpeed * Time.deltaTime; // Mover a la izquierda
            audioSource.Play();
            Debug.Log("Moviendo izquierda");
        }

        // Movimiento hacia la derecha
        if (Input.GetKey(KeyCode.D))
        {
            movement = moveSpeed * Time.deltaTime;  // Mover a la derecha
            audioSource.Play();
            Debug.Log("Moviendo derecha");
        }

        // Aplicar el movimiento usando transform.Translate
        transform.Translate(movement, Space.World);
    }
}
