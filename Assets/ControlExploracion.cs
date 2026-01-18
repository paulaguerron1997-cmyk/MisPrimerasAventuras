using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlExploration : MonoBehaviour
{
    [Header("Configuración")]
    public int totalAnimales = 6;
    private int animalesEncontrados = 0;

    [Header("UI")]
    public GameObject panelFinExploracion;

    void Start()
    {
        animalesEncontrados = 0;

        if (panelFinExploracion != null)
            panelFinExploracion.SetActive(false);

        // 🔒 Cursor bloqueado al iniciar
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // 👉 Llamado desde AnimalSound (UNA SOLA VEZ)
    public void AnimalVisitado()
    {
        animalesEncontrados++;

        Debug.Log("Animales encontrados: " + animalesEncontrados);

        if (animalesEncontrados >= totalAnimales)
        {
            MostrarPanelFinal();
        }
    }

    void MostrarPanelFinal()
    {
        if (panelFinExploracion != null)
            panelFinExploracion.SetActive(true);

        // 🔓 Liberar cursor
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // ⏸️ Pausar juego
        Time.timeScale = 0f;
    }

    // 👉 BOTÓN: Seguir jugando
    public void CerrarPanel()
    {
        if (panelFinExploracion != null)
            panelFinExploracion.SetActive(false);

        // 🔒 Volver a bloquear cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // ▶️ Reanudar juego
        Time.timeScale = 1f;
    }

    // 👉 BOTÓN: Menú (si luego lo usas)
    public void IrAlMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menuprincipal");
    }

    // 👉 BOTÓN: Nivel 2 (más adelante será otra escena)
    public void IrANivel2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Nivel2");
    }
}
















