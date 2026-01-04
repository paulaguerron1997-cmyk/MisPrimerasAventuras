using UnityEngine;

public class AnimalSound : MonoBehaviour
{
    private AudioSource audioSource;

    [Header("Configuración del Animal")]
    [Tooltip("Texto que aparecerá en pantalla al interactuar con este animal")]
    public string animalMessage = "¡Muuu!";

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Busca el AudioSource en este animal
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Solo el ratoncito
        {
            // ?? Reproducir sonido (onomatopeya)
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }

            // ?? Mostrar mensaje en UI
            if (AnimalMessageUI.Instance != null)
            {
                AnimalMessageUI.Instance.ShowMessage(animalMessage);
            }
        }
    }
}





