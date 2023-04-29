using UnityEngine;
using UnityEngine.UI;

public class ModalWindow : MonoBehaviour
{
    [SerializeField] private GameObject modalPanel;
    [SerializeField] private Text titleText;
    [SerializeField] private Text messageText;
    [SerializeField] private Button confirmButton;
    [SerializeField] private Button cancelButton;

    private System.Action onConfirm;
    private System.Action onCancel;

    private void Awake() {
        confirmButton.onClick.AddListener(OnConfirmActionClicked);
        cancelButton.onClick.AddListener(OnCancelActionClicked);
    }

    public void Show(string title, string message, System.Action onConfirm = null, System.Action onCancel = null)
    {
        this.onConfirm = onConfirm;
        this.onCancel = onCancel;

        titleText.text = title;
        messageText.text = message;

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
