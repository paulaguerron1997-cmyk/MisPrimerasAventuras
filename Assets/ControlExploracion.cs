using UnityEngine;

public class ControlExploration : MonoBehaviour
{
    [Header("Configuración")]
    public int totalAnimales = 6;              // Número total de animales del nivel
    private int animalesEncontrados = 0;       // Contador interno

    [Header("UI")]
    public GameObject panelFinExploracion;     // Panel con las opciones finales

    void Awake()
    {
        animalesEncontrados = 0;

        // Asegura que el panel empiece oculto
        if (panelFinExploracion != null)
            panelFinExploracion.SetActive(false);
    }

    // 👉 Llamado cada vez que el ratón visita un animal por primera vez
    public void AnimalVisitado()
    {
        animalesEncontrados++;

        Debug.Log("Animales encontrados: " + animalesEncontrados);

        if (animalesEncontrados >= totalAnimales)
        {
            MostrarPanelFinal();
        }
    }

    // 👉 Muestra el panel cuando se completa la exploración
    private void MostrarPanelFinal()
    {
        if (panelFinExploracion != null)
            panelFinExploracion.SetActive(true);
    }

    // 👉 BOTÓN: Seguir jugando
    public void CerrarPanel()
    {
        if (panelFinExploracion != null)
            panelFinExploracion.SetActive(false);
    }

    // 👉 BOTÓN: Volver al menú principal
    public void IrAlMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }

    // 👉 BOTÓN: Elegir actividad (Nivel 2)
    public void IrANivel2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MisPrimerasAventuras");
    }
}





