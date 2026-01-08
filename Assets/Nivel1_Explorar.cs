using UnityEngine;

public class ControlExploracion : MonoBehaviour
{
    public static ControlExploracion Instance;

    [Header("Configuración")]
    public int totalAnimales = 6;

    [Header("UI")]
    public GameObject panelFinExploracion;

    private int animalesDescubiertos = 0;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void AnimalDescubierto()
    {
        animalesDescubiertos++;

        Debug.Log("🐾 Animales descubiertos: " + animalesDescubiertos);

        if (animalesDescubiertos >= totalAnimales)
        {
            MostrarPanelFinal();
        }
    }

    void MostrarPanelFinal()
    {
        if (panelFinExploracion != null)
            panelFinExploracion.SetActive(true);
    }
}

