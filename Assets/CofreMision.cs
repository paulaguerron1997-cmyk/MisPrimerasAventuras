using UnityEngine;

public class CofreMision : MonoBehaviour
{
    [Header("Animal objetivo de esta misión")]
    public string animalObjetivo = "Vaca"; // 👈 cámbialo en el Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && GameManager.Instance != null)
        {
            GameManager.Instance.EstablecerMision(animalObjetivo);
        }
    }
}

