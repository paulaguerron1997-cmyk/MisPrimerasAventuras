using UnityEngine;

public class CameraFollowSimple : MonoBehaviour
{
    [Header("Configuración de cámara")]
    public Transform target;         // EL RATÓN
    public Vector3 offset = new Vector3(0f, 2f, -4f);
    public float followSpeed = 8f;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPos, followSpeed * Time.deltaTime);

        transform.LookAt(target.position + new Vector3(0, 1f, 0));
    }
}


