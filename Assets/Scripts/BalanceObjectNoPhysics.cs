using UnityEngine;

public class BalanceObjectNoPhysics : MonoBehaviour
{
    public float rotationSpeed = 100f;  // Velocidad de rotaci�n al presionar A o D
    public float returnSpeed = 2f;      // Velocidad para regresar a la posici�n original
    public float maxTiltAngle = 30f;    // �ngulo m�ximo de inclinaci�n

    private Quaternion originalRotation;  // Rotaci�n original del objeto
    private float currentTiltAngle = 0f;  // �ngulo actual de inclinaci�n

    void Start()
    {
        // Guardar la rotaci�n original
        originalRotation = transform.rotation;
    }

    void Update()
    {
        // Controlar el balanceo con A y D
        if (Input.GetKey(KeyCode.A))
        {
            // Inclinar hacia la izquierda
            currentTiltAngle = Mathf.Clamp(currentTiltAngle + rotationSpeed * Time.deltaTime, -maxTiltAngle, maxTiltAngle);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            // Inclinar hacia la derecha
            currentTiltAngle = Mathf.Clamp(currentTiltAngle - rotationSpeed * Time.deltaTime, -maxTiltAngle, maxTiltAngle);
        }
        else
        {
            // Si no se presiona ninguna tecla, volver lentamente a la posici�n original
            currentTiltAngle = Mathf.Lerp(currentTiltAngle, 0f, Time.deltaTime * returnSpeed);
        }

        // Aplicar la rotaci�n basada en el �ngulo actual
        ApplyRotation();
    }

    void ApplyRotation()
    {
        // Crear una nueva rotaci�n basada en el �ngulo de inclinaci�n
        Quaternion targetRotation = Quaternion.Euler(0, 0, currentTiltAngle);

        // Aplicar la rotaci�n al transform del objeto
        transform.rotation = originalRotation * targetRotation;
    }
}
