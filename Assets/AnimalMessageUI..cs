using UnityEngine;
using UnityEngine.UI;

public class AnimalMessageUI : MonoBehaviour
{
    public static AnimalMessageUI Instance;

    [Header("UI")]
    public Text messageText;       // Arrastra un Text de la UI
    public float messageDuration = 2f;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void ShowMessage(string message)
    {
        if (messageText != null)
        {
            messageText.text = message;
            CancelInvoke();
            Invoke(nameof(HideMessage), messageDuration);
        }
    }

    private void HideMessage()
    {
        if (messageText != null)
            messageText.text = "";
    }
}









