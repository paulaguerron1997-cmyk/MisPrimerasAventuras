using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target; // Asigna el GameObject del jugador aquí
    public float distance = 3f; // Distancia inicial más cercana
    public float height = 1.5f; // Altura sobre el personaje
    public float damping = 10f; // Suavizado más rápido
    public float mouseSensitivity = 100f; // Sensibilidad del mouse
    public float verticalRotationLimit = 80f; // Límite de rotación vertical

    private float currentX = 0f;
    private float currentY = 0f;

    void Start()
    {
        // Bloquear el cursor para una experiencia más inmersiva (opcional)
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void LateUpdate()
    {
        if (target == null) return;

        // Obtener entrada del mouse
        currentX += Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        currentY -= Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        currentY = Mathf.Clamp(currentY, -verticalRotationLimit, verticalRotationLimit);

        // Calcular rotación y posición de la cámara
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        Vector3 desiredPosition = target.position - (rotation * Vector3.forward * distance) + Vector3.up * height;

        // Verificación simple de colisión con el terreno
        RaycastHit hit;
        if (Physics.Raycast(target.position, (desiredPosition - target.position).normalized, out hit, distance))
        {
            if (hit.collider.gameObject.CompareTag("Terrain"))
            {
                desiredPosition = hit.point + Vector3.up * 0.2f; // Evitar atravesar el terreno
            }
        }

        // Suavizar el movimiento de la cámara
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);

        // Hacer que la cámara mire al personaje
        transform.LookAt(target.position + Vector3.up * (height / 2));
    }

    void OnDestroy()
    {
        // Liberar el cursor al salir (opcional)
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}