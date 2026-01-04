using UnityEngine;

public class AnimalMision : MonoBehaviour
{
    [Header("Configuración del Animal")]
    public string nombreAnimal = "Vaca";

    [Header("Audio")]
    public AudioClip sonidoAnimal;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 🎵 Reproduce sonido
            if (sonidoAnimal != null)
            {
                audioSource.clip = sonidoAnimal;
                audioSource.Play();
            }

            // 👉 Valida misión
            if (GameManager.Instance != null)
                GameManager.Instance.ValidarAnimal(nombreAnimal);
        }
    }
}


