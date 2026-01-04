using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [Header("Paneles")]
    public GameObject panelInformacion;

    [Header("Escena del juego")]
    public string nombreEscenaJuego = "MisPrimerasAventuras";

    void Start()
    {
        // Asegura que el panel de información empiece apagado
        if (panelInformacion != null)
        {
            panelInformacion.SetActive(false);
        }
    }

    // ▶️ BOTÓN JUGAR
    public void Jugar()
    {
        SceneManager.LoadScene(nombreEscenaJuego);
    }

    // ℹ️ BOTÓN INFORMACIÓN
    public void MostrarInformacion()
    {
        if (panelInformacion != null)
        {
            panelInformacion.SetActive(true);
        }
    }

    // ❌ BOTÓN CERRAR INFORMACIÓN
    public void CerrarInformacion()
    {
        if (panelInformacion != null)
        {
            panelInformacion.SetActive(false);
        }
    }

    // 🚪 OPCIONAL: SALIR DEL JUEGO
    public void Salir()
    {
        Application.Quit();
    }
}



