using UnityEngine;

public class CofreMisionTrigger : MonoBehaviour
{
    public string animalObjetivo = "Gato";
    public AudioClip sonidoMision;
    private AudioSource audioSource;
    private bool misionActivada = false;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Solo si entra el Player
        if (!misionActivada && other.CompareTag("Player"))
        {
            Debug.Log("🎁 Cofre: ratón entró - misión activada");

            if (sonidoMision != null)
                audioSource.PlayOneShot(sonidoMision);

            if (GameManager.Instance != null)
                GameManager.Instance.EstablecerMision(animalObjetivo);

            misionActivada = true;
        }
    }
}









