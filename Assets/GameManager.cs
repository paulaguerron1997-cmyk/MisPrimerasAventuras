using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public string animalObjetivo = "";

    private void Awake()
    {
        Debug.Log("GameManager activo en escena Nivel2");
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void EstablecerMision(string nuevoObjetivo)
    {
        animalObjetivo = nuevoObjetivo;
        Debug.Log("🔔 Busca al " + animalObjetivo + "!");
    }

    public void ValidarAnimal(string nombreAnimal)
    {
        if (string.IsNullOrEmpty(animalObjetivo))
        {
            Debug.LogWarning("⚠️ No hay misión activa todavía.");
            return;
        }

        if (nombreAnimal == animalObjetivo)
        {
            Debug.Log("🎉 Correcto: " + nombreAnimal);
            animalObjetivo = "";
        }
        else
        {
            Debug.Log("❌ Incorrecto: " + nombreAnimal);
        }
    }
}






