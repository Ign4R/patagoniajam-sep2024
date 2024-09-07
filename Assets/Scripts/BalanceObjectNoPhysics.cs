using UnityEngine;

public class BalanceObjectNoPhysics : MonoBehaviour
{
    public float rotationSpeed = 100f;  // Velocidad de rotación al presionar A o D
    public float returnSpeed = 2f;      // Velocidad para regresar a la posición original
    public float maxTiltAngle = 30f;    // Ángulo máximo de inclinación

    private Quaternion originalRotation;  // Rotación original del objeto
    private float currentTiltAngle = 0f;  // Ángulo actual de inclinación

    void Start()
    {
        // Guardar la rotación original
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
            // Si no se presiona ninguna tecla, volver lentamente a la posición original
            currentTiltAngle = Mathf.Lerp(currentTiltAngle, 0f, Time.deltaTime * returnSpeed);
        }

        // Aplicar la rotación basada en el ángulo actual
        ApplyRotation();
    }

    void ApplyRotation()
    {
        // Crear una nueva rotación basada en el ángulo de inclinación
        Quaternion targetRotation = Quaternion.Euler(0, 0, currentTiltAngle);

        // Aplicar la rotación al transform del objeto
        transform.rotation = originalRotation * targetRotation;
    }
}
