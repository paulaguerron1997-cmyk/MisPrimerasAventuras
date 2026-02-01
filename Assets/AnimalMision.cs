using UnityEngine;

public class AnimalMisionTrigger : MonoBehaviour
{
    public string nombreAnimal = "Gato";
    public AudioClip sonidoAnimal;
    private AudioSource audioSource;
    private bool yaValidado = false;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!yaValidado && other.CompareTag("Player"))
        {
            Debug.Log("🐾 Animal: ratón entró - " + nombreAnimal);

            if (sonidoAnimal != null)
                audioSource.PlayOneShot(sonidoAnimal);

            if (GameManager.Instance != null)
                GameManager.Instance.ValidarAnimal(nombreAnimal);

            yaValidado = true;
        }
    }
}






