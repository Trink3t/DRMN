using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ModalWindow : MonoBehaviour
{
    [SerializeField] private GameObject modalPanel;
    [SerializeField] private TMP_Text titleText;
    [SerializeField] private TMP_Text messageText;
    [SerializeField] private Button confirmButton;
    [SerializeField] private Button cancelButton;

    private System.Action onConfirm;
    private System.Action onCancel;

    private void Awake() {
        confirmButton.onClick.AddListener(OnConfirmActionClicked);
        cancelButton.onClick.AddListener(OnCancelActionClicked);

        modalPanel.SetActive(false);
    }

    public void Show(string title = null, string message = null, System.Action onConfirm = null, System.Action onCancel = null)
    {
        this.onConfirm = onConfirm;
        this.onCancel = onCancel;

        titleText.text = title;
        messageText.text = message;

        titleText.gameObject.SetActive(title != null);
        messageText.gameObject.SetActive(message != null);
        confirmButton.gameObject.SetActive(onConfirm != null);
        cancelButton.gameObject.SetActive(onCancel != null);

        modalPanel.SetActive(true);
    }

    private void OnCancelActionClicked()
    {
        modalPanel.SetActive(false);
        onCancel?.Invoke();
    }

    private void OnConfirmActionClicked()
    {
        modalPanel.SetActive(false);
        onConfirm?.Invoke();
    }
}
