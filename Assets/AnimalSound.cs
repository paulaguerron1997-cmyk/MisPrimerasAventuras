using UnityEngine;

public class AnimalSound : MonoBehaviour
{
    private AudioSource audioSource;
    private bool yaContado = false;

    [Header("Configuración del Animal")]
    public string animalMessage = "¡Muuu!";

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!audioSource.isPlaying)
                audioSource.Play();

            if (AnimalMessageUI.Instance != null)
                AnimalMessageUI.Instance.ShowMessage(animalMessage);

            // 👉 AVISAR AL CONTROLADOR (UNA SOLA VEZ)
            if (!yaContado)
            {
                ControlExploration control =
                    FindObjectOfType<ControlExploration>();

                if (control != null)
                {
                    control.AnimalVisitado();
                    yaContado = true;
                }
            }
        }
    }
}






