using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Misión actual")]
    public string animalObjetivo = "";  // Se asigna desde el cofre

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // 👉 Llamado desde el Cofre
    public void EstablecerMision(string nuevoObjetivo)
    {
        animalObjetivo = nuevoObjetivo;
        Debug.Log("🔔 Nueva misión: Busca " + animalObjetivo);

        if (AnimalMessageUI.Instance != null)
        {
            AnimalMessageUI.Instance.ShowMessage("🔔 Busca al " + animalObjetivo + "!");
        }
    }

    // 👉 Llamado desde el animal
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

            if (AnimalMessageUI.Instance != null)
            {
                AnimalMessageUI.Instance.ShowMessage("✅ ¡Muy bien! Era el " + nombreAnimal + " 🎉");
            }

            animalObjetivo = ""; // Misión completada
        }
        else
        {
            Debug.Log("❌ Incorrecto: " + nombreAnimal);

            if (AnimalMessageUI.Instance != null)
            {
                AnimalMessageUI.Instance.ShowMessage("❌ Ups... no era el " + nombreAnimal);
            }
        }
    }
}




