using UnityEngine;

public class RatonBienvenida : MonoBehaviour
{
    public AudioClip audioBienvenida;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.playOnAwake = false;
        audioSource.clip = audioBienvenida;
        audioSource.Play();
    }
}


