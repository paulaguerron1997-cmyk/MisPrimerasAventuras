using UnityEngine;

public class QuesitoManager : MonoBehaviour
{
    public GameObject quesitoPrefab;         // Arrastra aquí el Prefab del QuesitoUI
    public Transform contenedorQuesos;       // Arrastra aquí el ContenedorQuesos

    // Llamar a esta función cuando el ratón recoja un queso
    public void AgregarQuesito()
    {
        Instantiate(quesitoPrefab, contenedorQuesos);
    }
}

